using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManProject
{
    public partial class fNewLogin : Form
    {
        public fNewLogin()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearTextboxs()
        {
            txtUsername.Text = "";
            txtUserpwd.Text = "";
            txtUsername.Focus();
        }
        private int checkValidLogin (string username, string userpwd)
        {
            if (username.Equals("admin") && userpwd.Equals("admin")) return 1;
            if (username.Equals("libarian") && userpwd.Equals("libarian")) return 2;
            if (username.Equals("reader") && userpwd.Equals("reader")) return 3;
            return 0;
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string userpwd = txtUserpwd.Text;
                int check = checkValidLogin(username, userpwd);
                switch (check)
                {
                    case 0:
                        MessageBox.Show("Invalid username or password!!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.clearTextboxs();
                        break;
                    case 1:
                        MessageBox.Show("Login Successfully!\n Welcome " + username + "!",
                                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fAdmMainMenu menu = new fAdmMainMenu(username);
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                        this.clearTextboxs();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        MessageBox.Show("Some errors occur! Returned value of checkValidLogin() is invalid",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            catch
            {
                MessageBox.Show("Some errors occur!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                /// close connection to server here. Later :")
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
                this.Close();
            else this.clearTextboxs();
        }
    }
}
