using System;
using System.Windows.Forms;
using ChatServer3AA.Properties;

namespace ChatServer3AA
{
    public partial class PortForm : Form
    {
        public PortForm()
        {
            InitializeComponent();
            setPortTextBox.Text = Convert.ToString(Settings.Default.Port);
        }

        private void savePortButton_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Port = Convert.ToInt32(setPortTextBox.Text);
                Settings.Default.Save();
                this.Close();
            }
            catch (Exception exa)
            {
                MessageBox.Show(this, exa.Message);
            }
        }

        private void cancelPortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnPortChanged(object sender, EventArgs e)
        {
            int result;
            this.savePortButton.Enabled = int.TryParse(this.setPortTextBox.Text, out result);
        }
    }
}
