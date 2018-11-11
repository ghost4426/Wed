using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public string TableName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime DateCreate { get; set; }
    }
}