using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string DateCreate { get; set; }
        public int Total { get; set; }
    }
}