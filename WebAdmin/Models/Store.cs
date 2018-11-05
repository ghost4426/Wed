using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreKey { get; set; }
        public string Location { get; set; }
        public string StoreName { get; set; }
        public string PhoneNumber { get; set; }
        public string Province { get; set; }
    }
}