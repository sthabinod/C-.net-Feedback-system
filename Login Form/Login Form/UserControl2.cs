using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Login_Form
{
    public partial class UserControl2 : UserControl
    {
        
       

        public UserControl2()
        {
            InitializeComponent();
        }

     

     

        public List<Details> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new Details
                        {
                            Name = data[0],
                            Phone = data[1],
                            Address = data[2],
                            Email = data[3],
                            Food = data[4],
                            Services = data[5],
                            Hos = data[6]
                        };

            return query.ToList();
        }

      

        


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtboxBrowse.Text = dlg.FileName;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = LoadCSV(txtboxBrowse.Text);
            lblRating.Text ="The total rating is: "+ bunifuCustomDataGrid1.RowCount.ToString();
            /*bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns[1], ListSortDirection.Ascending);*/
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }

    public class Details
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string Food { get; set; }
        public string Services { get; set; }

        public string Hos { get; set; }
    }
}
