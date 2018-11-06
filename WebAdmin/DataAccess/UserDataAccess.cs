﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebAdmin.Models;

using WebAdmin.DataAccess;

namespace WebAdmin.DataAccess
{
    public class UserDataAcess
    {

        public static List<User> getListUser()
        {
            string url = "http://" + APIConfig.IpAddress + ":3000/user-getAllUser";
            string json = APIConfig.CallApi(url, "GET");
            List<User> user = JsonConvert.DeserializeObject<List<User>>(json);
            return user;
        }

        public static void addUser(String UserName,String FullName,String Address,int StoreId,int RoleId,String Password)
        {
            String param = UserName +"&"+ FullName + "&"+ Address + "&"+ StoreId + "&"+ RoleId + "&"+ Password;
            string url = "http://" + APIConfig.IpAddress + ":3000/user/"+param;
            string json = APIConfig.CallApi(url, "POST");
          
        }
    }

}
