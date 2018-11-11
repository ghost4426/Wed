﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public string TableName { get; set; }
        public DateTime DateCreate { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Total { get; set; }
    }
}