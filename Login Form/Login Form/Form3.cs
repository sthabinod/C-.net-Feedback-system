using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form3 : Form
    {
        string password_form_one;
            public Form3()
        {
            InitializeComponent();
            password_form_one = Login.userPassword;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Login login = new Login();
           
            string passwords = inputPassword.Text;
            string newpassword = inputPasswordAgain.Text;

            if (passwords==password_form_one)
            {
                password_form_one = newpassword; 
                Login.userPassword = password_form_one;
                MessageBox.Show("Password has been set successfully!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Old Password is not matched!");
            }
        }

   

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
