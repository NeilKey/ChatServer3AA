using System;
using System.Collections;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using ChatServer3AA.Properties;

namespace ChatServer3AA
{
    public partial class UserAccountsForm : Form
    {
        private const int colNickname = 0, colUsername = 1, colPassword = 2, colEnabled = 3;  // Indici delle colonne
        private const int ascIconIndex = 0, descIconIndex = 1, noneIconIndex = 2;  // Indici delle icone per il sorting
        private const int ascSortOrder = 1, descSortOrder = -1;  // Valori per il calcolo del sorting

        private ColumnHeader[] columnHeaders;

        public UserAccountsForm()
        {
            InitializeComponent();

            columnHeaders = new ColumnHeader[] { columnHeaderNickname, columnHeaderUsername, columnHeaderPassword, columnHeaderEnabled };

            PopulateAccountList();
        }

        private void PopulateAccountList()
        {
            // Sorting di default, se si ripopola la listView dopo un sorting senza impostare null a ListViewItemSorter,
            // allora il metodo Compare() della classe ListViewItemComparer verrà invocato non appena si aggiunge la seconda
            // item
            // Dato che la classe memorizza l'ultima colonna utilizzata per il sorting, e se la colonna non è la prima (0),
            // si genera una exception perché si tenterà di eseguire il sorting su una colonna non ancora esistente per la
            // item appena aggiunta (accountListView.Items.Add()), infatti Compare viene invocato subito dopo Add() ma prima
            // di SubItems.AddRange()
            // Vedi
            //   return String.Compare(((ListViewItem) x).SubItems[m_column].Text, ((ListViewItem) y).SubItems[m_column].Text) * m_order;
            accountListView.ListViewItemSorter = null;

            accountListView.Items.Clear();

            // Inizializza l'icona di ordinamento delle prime tre colonne
            columnHeaderNickname.ImageIndex = noneIconIndex;
            columnHeaderUsername.ImageIndex = noneIconIndex;
            columnHeaderPassword.ImageIndex = noneIconIndex;
            columnHeaderEnabled.ImageIndex = noneIconIndex;

            SqlCeConnection conn = null;
            SqlCeCommand cmd = null;

            try
            {
                conn = new SqlCeConnection(Settings.Default.UserAccountsConnectionString);
                conn.Open();

                cmd = new SqlCeCommand("SELECT * FROM [UserAccounts];", conn);

                SqlCeDataReader reader = cmd.ExecuteReader();
                cmd.Dispose();

                // Per ragioni di performances, utilizzare GetOrdinal() all'esterno del loop while(reader.Read())
                int idUsername = reader.GetOrdinal("Username");
                int idPassword = reader.GetOrdinal("Password");
                int idNickname = reader.GetOrdinal("Nickname");
                int idEnabled = reader.GetOrdinal("Enabled");

                while (reader.Read())
                {
                    accountListView.Items.Add(reader.GetString(idNickname)).SubItems.AddRange(new string[] {
                        reader.GetString(idUsername),
                        reader.GetString(idPassword),
                        (reader.GetInt16(idEnabled) != 0) ? "Yes" : "No" });
                }

                conn.Close();
            }
            catch (Exception e)
            {
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Close();

                MessageBox.Show(e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column <= colEnabled)
            {
                // Seleziona l'ordinamento per le prime tre colonne: Nickname, Username e Password
                for (int id = 0 ; id < columnHeaders.Length ; id++)
                {
                    columnHeaders[id].ImageIndex = (e.Column == id) ?
                        ((columnHeaders[id].ImageIndex != noneIconIndex) ? descIconIndex - columnHeaders[id].ImageIndex : ascIconIndex) :
                        noneIconIndex;
                }

                // La property ListViewItemSorter contiene una classe che implementa l'interface IComparer
                // Ogni volta che si riassegna questa property, il processo di sorting viene avviato
                accountListView.ListViewItemSorter = new ListViewItemComparer(e.Column, (columnHeaders[e.Column].ImageIndex == ascIconIndex) ? ascSortOrder : descSortOrder);
            }
        }

        private void SetEnableState()
        {
            // Dopo il ciclo di for, status assume i seguenti valori:
            //   1: tutti gli accounts selezionati sono disabilitati
            //   2: tutti gli accounts selezionati sono abilitati
            //   3: la selezione contiene sia accounts abilitati che disabilitati
            int status = 0;
            int cnt = accountListView.SelectedItems.Count;
            for (int n = 0 ; n < cnt ; n++)
            {
                if (accountListView.SelectedItems[n].SubItems[3].Text == "Yes")
                    status |= 2;
                else
                    status |= 1;

                // Se lo status ha il valore 3, esci dal ciclo
                if (status == 3)
                    break;
            }

            menuEnable.CheckState = (status == 2) ? CheckState.Checked : ((status == 1) ? CheckState.Unchecked : CheckState.Indeterminate);
        }

        private void OnOpeningContextMenu(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int cnt = accountListView.SelectedItems.Count;

            // Abilita le context-menu-items "Enable" e "Delete" solo se è selezionata almeno una item della lista accounts
            menuEnable.Enabled = menuDelete.Enabled = cnt > 0;

            if (menuEnable.Enabled)
                SetEnableState();
            else
                menuEnable.CheckState = CheckState.Unchecked;
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            PopulateAccountList();
        }

        private void OnEnable(object sender, EventArgs e)
        {
            if (!menuEnable.Enabled)
                return;

            SqlCeConnection conn = null;
            SqlCeCommand cmd = null;

            try
            {
                conn = new SqlCeConnection(Settings.Default.UserAccountsConnectionString);
                conn.Open();

                SetEnableState();  // Aggiorna lo stato di "CheckState" della menu item "Enable selected accounts"

                // Abilita/disabilita gli utenti selezionati
                int iEnabled = (menuEnable.CheckState != CheckState.Checked) ? 1 : 0;
                string strEnabled = (iEnabled != 0) ? "Yes" : "No";
                int cnt = accountListView.SelectedItems.Count;

                // Itera tutti gli utenti selezionati
                for (int n = 0 ; n < cnt ; n++)
                {
                    cmd = new SqlCeCommand("UPDATE [UserAccounts] SET [Enabled] = @enabled WHERE [Username] = @username;", conn);
                    cmd.Parameters.AddWithValue("@enabled", iEnabled);
                    cmd.Parameters.AddWithValue("@username", accountListView.SelectedItems[n].SubItems[colUsername].Text);
                    int cntAffected = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (cntAffected == 1)
                        accountListView.SelectedItems[n].SubItems[colEnabled].Text = strEnabled;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Close();

                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            if (!menuDelete.Enabled)
                return;

            if (MessageBox.Show("Do you want to delete selected accounts?", "Delete Accounts", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            SqlCeConnection conn = null;
            SqlCeCommand cmd = null;

            try
            {
                conn = new SqlCeConnection(Settings.Default.UserAccountsConnectionString);
                conn.Open();

                int cnt = accountListView.SelectedItems.Count;

                // Itera tutti gli utenti selezionati
                for (int n = cnt - 1 ; n >= 0 ; n--)
                {
                    cmd = new SqlCeCommand("DELETE FROM [UserAccounts] WHERE [Username] = @username;", conn);
                    cmd.Parameters.AddWithValue("@username", accountListView.SelectedItems[n].SubItems[colUsername].Text);
                    int cntAffected = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (cntAffected == 1)
                        accountListView.SelectedItems[n].Remove();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Close();

                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Implementa l'interface per il sorting
    class ListViewItemComparer : IComparer
    {
        private int m_column, m_order;

        public ListViewItemComparer(int column, int order)
        {
            m_column = column;
            m_order = (order > 0) ? 1 : ((order < 0) ? -1 : 0);  // 0 = no sort
        }

        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem) x).SubItems[m_column].Text, ((ListViewItem) y).SubItems[m_column].Text) * m_order;
        }
    }
}
