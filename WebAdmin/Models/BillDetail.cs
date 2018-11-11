using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class BillDetail
    {


        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int ProductPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Price { get; set; }

    }
}