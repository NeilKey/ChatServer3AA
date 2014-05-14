using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using ChatServer3AA.Properties;

namespace ChatServer3AA
{
    public partial class ChatServerForm : Form
    {
        public String serverHostName = "";
        public String serverIP = "";
        public String serverPort = "";

        public ChatServerForm()
        {
            InitializeComponent();
            // Questa particolare stringa restituisce il nome dell'host
            serverHostName = Dns.GetHostName();

            // Questa parte di codice restituisce l'ip dell'host
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipAddress in ipEntry.AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    serverIP = ipAddress.ToString();
                }
            }
            // visualizza tramite settings la porta da utilizzare
            serverPort = Convert.ToString(Settings.Default.Port);

            hostNameLabel.Text = serverHostName;
            hostIPLabel.Text = serverIP;
            hostPortLabel.Text = serverPort;
        }

        private void portLabel_Click(object sender, EventArgs e)
        {
            PortForm pfrm = new PortForm();
            if (pfrm.ShowDialog() != DialogResult.OK)
                return;

            hostPortLabel.Text = Convert.ToString(Settings.Default.Port);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(new IPEndPoint(Convert.ToInt32(serverIP), Convert.ToInt32(serverPort)));
        }

        private void OnUserAccounts(object sender, EventArgs e)
        {
            UserAccountsForm userAccounts = new UserAccountsForm();
            userAccounts.ShowDialog();
        }
    }
}
