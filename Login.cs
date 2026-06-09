using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSOLogger
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string log_user = "admin";
        string log_pass = "admin";

        private bool Login_Check()
        {
            if (user.Text == log_user && pass.Text == log_pass)
            {
                return true;
            }
            
            return false;
        }

        private void Login_Resolver()
        {
            if (Login_Check())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime ili lozinka!");
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            Login_Resolver();
        }

        private void user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Login_Resolver();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
