using DailyActivityTracker.BLL.Services;
using DailyActivityTracker.DAL.Models;
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
    public partial class Signup : Form
    {
        private static string user = "Enter username";
        private static string pass = "Enter password";
        private static string rePass = "Retype password";
        public Signup()
        {
            InitializeComponent();
            txtUser.TabStop = false;
            txtPass.TabStop = false;
            txtRetypePass.TabStop = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            txtUser.Text = user;
            txtPass.Text = pass;
            txtRetypePass.Text = rePass;
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

        private void txtRetypePass_Leave(object sender, EventArgs e)
        {
            if(txtRetypePass.Text == "")
            {
                txtRetypePass.Text = rePass;
            }
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

        private void txtRetypePass_Enter(object sender, EventArgs e)
        {
            if(txtRetypePass.Text == rePass)
            {
                txtRetypePass.Text = "";
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = txtUser.Text;
            user.Password = txtPass.Text;

            if(Facade.AuthServices.Signup(user))
            {
                if(MessageBox.Show("New user added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("User add failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
