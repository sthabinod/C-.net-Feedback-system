using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Login_Form.CustomerRatingDetails;

namespace Login_Form
{
    public partial class Form2 : Form
    {
        IDictionary<string, int> keyValueOfCriteriaPoint = new Dictionary<string, int>();
        ArrayList al = new ArrayList();
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
                    }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl31.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*keyValueOfCriteriaPoint.Add("Food", 5);
            keyValueOfCriteriaPoint.Add("Services", 2);*/

            CustomerRatingDetails cs0 = new CustomerRatingDetails("inputCustomerName.Text", "inputCustomerNumber.Text", "inputCustomerAddress.Text", "inputCustomerEmail.Text", keyValueOfCriteriaPoint);
            

            al.Add(cs0);//12
            //al.Add(cs1);//12
            //al.Add(cs2);//12
            //al.Add(cs3);//12
            //al.Add(cs4);//12

            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();

            Form4 f = new Form4();
            //f.

            //int[] arr= { };
            //foreach (CustomerRatingDetails c in al)
            //{
              //  IDictionary<string,int> d = c.GetRow();
                //foreach(KeyValuePair<string,int> kv in d)
                //{
                    //int food = kv.Value
                    
                    //arr = new int[]{ ValueType};
                   
                //}
                
           // }
//            MessageBox.Show(arr[0].ToString());

  //          int n = 1000, i;
    //        Console.WriteLine("Quick Sort");
      //      Console.Write("Initial array is: ");
        //    for (i = 0; i < n; i++)
          // {
           //   Console.Write(arr[i] + " ");
            //}
               // Class1.quickSort(arr, 0, 20);
              // Console.Write("\nSorted Array is: ");
            //for (i = 0; i < n; i++)
            //{
              // MessageBox.Show(arr[i].ToString());
              // Console.Write(arr[i] + " ");
           // }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();


        }

        private void userControl41_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
