using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop_test.Models
{
    public class Purchase
    {
        public int Purchaseid { get; set; }
        public int PhoneID { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string Fio { get; set; }
        public string Adress { get; set; }
    }
}