using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using Login_Form;
using System.IO;
using System.Linq;


namespace Login_Form
{
    public partial class Form4 : Form
    {
        IDictionary<string, int> keyValueOfCriteriaPoint = new Dictionary<string, int>();
        Queue<string> queue = new Queue<string>();
        Queue<string> category = new Queue<string>();
        public ArrayList objList = new ArrayList();
        int[] listOfFeedbackPoint;//1,2,3,2
        List<int> list = new List<int>();
        string food_rating;
        string services_rating;
        string hos_rating;
        string[] criteria = new string[3] { "Food", "Services", "Money" };

        Queue<string> name;

        public Form4()
        {
            InitializeComponent();
            Queue<string> queue = UserControl1.q;
            for(var i= 1; i< criteria.Length; i++)
            {
                name = new Queue<string>();
                name.Enqueue("name" + i);

            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your feedback saved successfully!");
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //  {
        //    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        //}


        private void Form4_Load(object sender, EventArgs e)
        {
            foreach(string c in criteria)
            {
                tabControl1.TabPages.Add(c);
             
         

                if (dis2.Checked)
                {
                    services_rating = "5";
                }
                else if (average2.Checked)
                {
                    services_rating = "10";
                }
                else if (good2.Checked)
                {
                    services_rating = "15";
                }
                else if (excellent2.Checked)
                {
                    services_rating = "20";
                }
                else
                {
                    services_rating = "0";
                }
            }
            

            //category.Enqueue("Good ");
            //category.Enqueue("Excellent");
            //category.Enqueue("Bad");
            //category.Enqueue("Satisfactory");
            //category.Enqueue("Well ");

            //dataGridView1.Refresh();
            //dataGridView1.Update();
            //DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            //dataGridView1.ColumnCount = 4;
            //dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            //dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //dataGridView1.Columns[0].Name = "";
            //dataGridView1.Columns[1].Name = "Good ";
            //dataGridView1.Columns[2].Name = "Bad";
            //dataGridView1.Columns[3].Name = "Excellent";


            list.Add(1);
            list.Add(2);

            queue.Enqueue("Good Food");
            queue.Enqueue("Services");
            queue.Enqueue("Health Care");
            queue.Enqueue("Dishes");
            queue.Enqueue("Hospatility");

            //dataGridView1.Refresh();
            //dataGridView1.Update();
            //foreach (string c in queue)
            //{

            //   dataGridView1.Rows.Add(c);

            // }
            string[] row1 = new string[] { "Datafrom Admin", "Main Dish", "ground beef",
        "**" };
            string[] row2 = new string[] { "Data from Admin", "Dessert",
        "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Data from admin", "Main Dish",
        "pork chops, salsa, orange juice", "****" };
            string[] row4 = new string[] { "Data from admin", "Salad",
        "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Data from admin", "Dessert",
        "cream cheese", "***" };
            string[] row6 = new string[] { "Data from Admin", "Appetizer",
        "black beans, sour cream", "***" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            // foreach (string[] rowArray in rows)
            //{
            // dataGridView1.Rows.Add(rowArray);
            //}

            //dataGridView1.Columns[4].Name = "Satisfactory";
            //foreach (string c in category)
            //{

            //dataGridView1.Rows.Add(c);

            //        }
        }

        private void lblGrid_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (inputCustomerName.Text == "" && inputCustomerNumber.Text == "" && inputCustomerAddress.Text == "" && inputCustomerEmail.Text == "")
            {
                MessageBox.Show("Please enter your details properly.");
            }
            else
            {
                keyValueOfCriteriaPoint.Clear();
             /*   av1.Checked = false;
                dis1.Checked = false;
                good1.Checked = false;
                excellent1.Checked = false;
                average2.Checked = false;
                dis2.Checked = false;
                good2.Checked = false;
                excellent2.Checked = false;*/

                foreach (KeyValuePair<string, int> entry in keyValueOfCriteriaPoint)
                {
                    int va = entry.Value;

                    MessageBox.Show(va.ToString(), entry.Key);


                }
                DateTime dt = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
                c.Text = dt.ToString();




                //for loop of all the key and value

                //foreach (string i in queue)
                //{
                //  foreach(int j in list)
                //{
                //   keyValueOfCriteriaPoint.Add(i, j);
                // break;
                //}


                //}
                //keyValueOfCriteriaPoint.Add("Food", 2);
                //keyValueOfCriteriaPoint.Add("Services", 1);
                //keyValueOfCriteriaPoint.Add("Hospitality", 0);
                //keyValueOfCriteriaPoint.Add("Educate", 2);
                //keyValueOfCriteriaPoint.Add("Cleanliness", 1);
                //foreach (var kvp in keyValueOfCriteriaPoint)
                // MessageBox.Show("Key: {0}, Value: {1}"+ kvp.Key+kvp.Value);



                CustomerRatingDetails cs = new CustomerRatingDetails(inputCustomerName.Text, inputCustomerNumber.Text, inputCustomerAddress.Text, inputCustomerEmail.Text, keyValueOfCriteriaPoint);

                objList.Add(cs);

                foreach (CustomerRatingDetails c in objList)
                {
                    IDictionary<string, int> var = c.GetRow();
                    foreach (KeyValuePair<string, int> i in var)
                    {
                        int key = i.Value;
                        Console.WriteLine(key);
                    }

                }
                if (objList != null)
                {
                    MessageBox.Show("The number of feedback is " + cs.name + objList.Count.ToString());
                }
                else
                {
                    MessageBox.Show("No object found!");
                }



                //}
                //foreach (int i in objList)
                //{
                //  MessageBox.Show(i.ToString());
                //}


            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            // }
        }
       
        /*public void Check()
        {
           
            foreach(string count in name)
            {
                count = c;
                if (dis1.Checked)
                {
                    count = "5";
                }
                else if (av1.Checked)
                {
                    food_rating = "10";
                }
                else if (good1.Checked)
                {
                    food_rating = "15";
                }
                else if (excellent1.Checked)
                {
                    food_rating = "20";
                }
                else
                {
                    food_rating = "0";
                }
            }
        }*/

        public void FoodCheck()
        {
            if (dis1.Checked)
            {
                food_rating = "5";
            }
            else if (av1.Checked)
            {
                food_rating = "10";
            }
            else if (good1.Checked)
            {
                food_rating = "15";
            }
            else if (excellent1.Checked)
            {
                food_rating = "20";
            }
            else
            {
                food_rating = "0";
            }

        }

        public void ServicesCheck()
        {
            if (dis2.Checked)
            {
                services_rating = "5";
            }
            else if (average2.Checked)
            {
                services_rating = "10";
            }
            else if (good2.Checked)
            {
                services_rating = "15";
            }
            else if (excellent2.Checked)
            {
                services_rating = "20";
            }
            else
            {
                services_rating = "0";
            }

        }

        public void HospitalityCheck()
        {
            if (dis3.Checked)
            {
                hos_rating = "5";
            }
            else if (satisfied3.Checked)
            {
                hos_rating = "10";
            }
            else if (good3.Checked)
            {
                hos_rating = "15";
            }
            else if (excellent3.Checked)
            {
                hos_rating = "20";
            }
            else
            {
                hos_rating = "0";
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {



            ServicesCheck();
            HospitalityCheck();
            FoodCheck();
            MessageBox.Show("S"+services_rating + "F"+food_rating + "H"+hos_rating);
            /* string[] row = new string[] { inputCustomerName.Text, inputCustomerNumber.Text, inputCustomerAddress.Text, inputCustomerEmail.Text, services_rating, hos_rating, food_rating };
             bunifu.Rows.Add(row);
*/

            try
            {
                
                using (StreamWriter streamWriter = File.AppendText(@"C:\Users\Bee-nod\Desktop\Courseworks\C# Sem Coursework\File\hello.csv"))
                {

                    streamWriter.WriteLine("{0},{1},{2},{3},{4},{5},{6}", inputCustomerName.Text, inputCustomerNumber.Text, inputCustomerAddress.Text, inputCustomerEmail.Text, food_rating, services_rating, hos_rating );
                    MessageBox.Show("You file has been added");

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This file is Open::");
            }
            /* try
         {
             using (StreamWriter streamWriter = File.AppendText(@"C:\Users\Bee-nod\Desktop\Courseworks\C# Sem Coursework\File\hello.csv"))
             {
                 foreach (CustomerRatingDetails details in objList)
                 {    streamWriter.WriteLine("{0},{1},{2},{3},{4},{5}", details.GetName(), details.GetAddress(), details.GetPhone(), details.GetEmail(), tabPage1.Text+ 1,tabPage2.Text+1);
                 }
             }*/
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }





        /* catch (Exception ex)
         {
             MessageBox.Show(ex.Message);
         }*/


    }

    /*  private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
          {*/
    /* List<CustomerRatingDetails> values = File.ReadAllLines(@"C:\Users\Bee-nod\Desktop\hello.csv")
                                    .Skip(1)
                                    .Select(v => CustomerRatingDetails.FromCsv(v))
                                    .ToList();*/

    //read csv files
    //string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\Bee-nod\Desktop\hello.csv");

    //split each row into column data
    //for(int i = 1; i<csvLines.Length;i++)
    //{

    //}

    /*        }
    */

    /*  

       private void button2_Click(object sender, EventArgs e)
       {
           tabControl1.SelectedTab = tabPage2;
           try
           {
               if (badOne.Checked == true)
               {
                   keyValueOfCriteriaPoint.Add(tabPage1.Text, 1);
                   MessageBox.Show("Value Added");
                   return;
               }
               else if (goodOne.Checked == true)
               {
                   keyValueOfCriteriaPoint.Add(tabPage1.Text, 2);
                   return;
               }
               else if (excellentThree.Checked == true)
               {
                   keyValueOfCriteriaPoint.Add(tabPage1.Text, 3);
                   return;
               }

               else if (outstandingFour.Checked == true)
               {
                   keyValueOfCriteriaPoint.Add(tabPage1.Text, 4);
                   return;
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show("You have given rate already");
           }

       }*/
    /*
            private void button1_Click_1(object sender, EventArgs e)
            {
                try
                {
                    if (badTwo.Checked == true)
                    {
                        keyValueOfCriteriaPoint.Add(tabPage2.Text, 1);
                        return;
                    }
                    else if (goodTwo.Checked == true)
                    {
                        keyValueOfCriteriaPoint.Add(tabPage2.Text, 2);
                        return;
                    }
                    else if (excellentTwo.Checked == true)
                    {
                        keyValueOfCriteriaPoint.Add(tabPage2.Text, 3);
                        return;
                    }

                    else if (outstandingTwo.Checked == true)
                    {
                        keyValueOfCriteriaPoint.Add(tabPage2.Text, 4);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }*/

    /*  private void inputCustomerName_OnValueChanged(object sender, EventArgs e)
      {
          if (inputCustomerName.Text == "Customer Name")
          {
              inputCustomerName.Text = "";
          }
      }*/

    /*   private void inputCustomerNumber_OnValueChanged(object sender, EventArgs e)
       {
           if (inputCustomerNumber.Text == "Customer Phone")
           {
               inputCustomerNumber.Text = "";
           }
       }*/

    /*    private void inputCustomerAddress_OnValueChanged(object sender, EventArgs e)
        {
            if (inputCustomerAddress.Text == "Customer Address")
            {
                inputCustomerAddress.Text = "";
            }
        }*/
}

