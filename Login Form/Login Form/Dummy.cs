using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form
{
   
    /*
     * To change this license header, choose License Headers in Project Properties.
     * To change this template file, choose Tools | Templates
     * and open the template in the editor.
     */

    public class CustomerRatingDetails
    {
        public string name;
        private string email;
        private string address;
        private string phone;
        private IDictionary<string, int> dict = new Dictionary<string, int>();

        public CustomerRatingDetails(string name, string email, string address, string phone,IDictionary<string,int> dict)
        {
            this.name =name;
            this.email= email;
            this.address = address;
            this.phone = phone;
            this.dict= dict;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetPhone()
        {
            return phone;
        }

        public IDictionary<string,int> GetRow()
        {
            return dict;
        }

      
    }

}
