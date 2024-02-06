using DailyActivityTracker.BLL.Services;
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

        private string userName = String.Empty;
        private string password = String.Empty;
        public Login()
        {
            InitializeComponent();
            txtUser.TabStop = false;
            txtPass.TabStop = false;
        }

        private new bool Validate()
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

            userName = txtUser.Text;
            password = txtPass.Text;
            return true;
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                if(!Facade.AuthServices.Login(userName, password))
                {
                    MessageBox.Show("No user exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
            }
        }
    }
}
