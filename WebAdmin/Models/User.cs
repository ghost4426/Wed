using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    public class User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public string RoleType { get; set; }
        public string Address { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        
    }
}