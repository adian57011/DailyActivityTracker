using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyActivityTracker.Forms
{
    public partial class Login : Form
    {
        private static string user = "Enter username";
        private static string pass = "Enter password";
        public Login()
        {
            InitializeComponent();
            txtUser.TabStop = false;
            txtPass.TabStop = false;
        }

        private bool Validate()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Enter Login", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup log = new Signup();
            log.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Text = user;
            txtPass.Text = pass;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == user)
            {
                txtUser.Text = "";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == pass)
            {
                txtPass.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = user;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = pass;
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
        }
    }
}
