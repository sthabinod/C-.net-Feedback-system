using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Login_Form
{
    public partial class UserControl1 : UserControl
    {
        public static Queue<string> q = new Queue<string>();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your feedback saved successfully!");
        }

        private void inputUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void inputPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

    

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string criteria = criteraiName.Text;
            if(string.IsNullOrEmpty(criteria) && string.IsNullOrEmpty(criteriaNumber.Text))
            {
                MessageBox.Show("Please! Complete the form properly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                q.Enqueue(criteria);
                MessageBox.Show("Your criteria is saved successfully!", "Add Criteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          



           




        }

        private void showNow_Click(object sender, EventArgs e)
        {
           
        }

       
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
