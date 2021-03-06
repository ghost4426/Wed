﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ImgKey { get; set; }
        public string ImgPath { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public int IsAvailable { get; set; }
    }
}