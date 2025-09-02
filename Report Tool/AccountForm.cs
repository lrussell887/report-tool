using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerIOClient;

namespace Report_Tool
{
    public partial class AccountForm : Form
    {
        public Client Client { get; set; }
        public Connection Connection { get; set; }

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Shown(object sender, EventArgs e)
        {
            string email = Properties.Settings.Default.Email;
            string password = Properties.Settings.Default.Password;

            if (!string.IsNullOrWhiteSpace(email) || !string.IsNullOrWhiteSpace(password))
            {
                txtEmail.Text = email;
                txtPassword.Text = password;
            }

            btnLogin.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool remember = chkRemember.Checked;

            if (remember)
            {
                Properties.Settings.Default.Email = email;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }

            Login(email, password);

            if (Client != null || Connection != null)
            {
                slblStatus.Text = "Connected";
                DialogResult = DialogResult.OK;
            }

            slblStatus.Text = "Ready";
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        public void Login(string email, string password)
        {
            try
            {
                slblStatus.Text = "Connecting";

                Client = PlayerIO.QuickConnect.SimpleConnect("everybody-edits-su9rn58o40itdbnw69plyw", email, password, null);
                Connection = Client.Multiplayer.CreateJoinRoom(Client.ConnectUserId + "-TROOM", "TRoom", false, null, null);

                Connection.OnDisconnect += delegate (object sender, string message)
                {
                    if (message != "Disconnect")
                    {
                        MessageBox.Show("You were disconnected from the Tool Room.", "Login Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                };
            }
            catch (Exception ex)
            {
                slblStatus.Text = "Error";
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
