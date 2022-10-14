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
    public partial class fAdmMainMenu : Form
    {
        public fAdmMainMenu(string username)
        {
            InitializeComponent();
            butAccount.Text = username;
            this.Username = username;
        }

        public string Username { get; internal set; }

        private void butLogout_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Close();
        }
    }
}
