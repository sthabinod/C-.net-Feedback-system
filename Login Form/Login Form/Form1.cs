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
    public partial class Login : Form
    {
        public static string userName = "admin";
        public static string userPassword = "admin";

        Form form = new Form2();
        public Login()
        {
            InitializeComponent();
            
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(inputUsername.Text == userName && inputPassword.Text == userPassword)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();


            }

            else
            {
                MessageBox.Show("Please! Enter the correct username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

     
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            inputUsername.Text = "";
            inputPassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Form4 user_rate= new Form4();
            user_rate.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
