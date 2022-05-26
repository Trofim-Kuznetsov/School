using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please, enter username and password");
            }
            else if(UnameTb.Text == "Admin" & PasswordTb.Text == "Admin")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                UnameTb.Text = "";
                PasswordTb.Text = "";

            }
        }
    }
}
