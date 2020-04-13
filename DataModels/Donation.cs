using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Donation
    {
        public string Organization { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact_No { get; set; }
                
        public string Email { get; set; }
        public int Amount { get; set; }
    }
}