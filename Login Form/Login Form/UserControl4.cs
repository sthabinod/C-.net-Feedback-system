using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
            
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

       

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            
        }
    }
}
