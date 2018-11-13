using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class Order
    {
        public int StoreId { get; set; }
        public int TableId { get; set; }
        public int OrderId { get; set; }
        public string TableName { get; set; }
        public string StoreName { get; set; }
        public DateTime DateCreate { get; set; }
        public string Total { get; set; }
        public string Status { get; set; }
        public int ProductPrice { get; set; }

        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public int Price { get; set; }

    }
}