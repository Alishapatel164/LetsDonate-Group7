using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Donation
    {
        public string Organization { get; set; }
        public string Donar_name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Contact_No { get; set; }    
        public string Email_id { get; set; }
        public int Amount { get; set; }
        public string Our_Org { get; set; }
    }
}