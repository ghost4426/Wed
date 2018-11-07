using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class HomeDataAccess
    {
        public static User CheckLogin(string username, string password)
        {
            User user = null;
            List<User> users;
            string url = "/checklogin/" +  username + "&" + password;
            string json = APIConfig.CallApi(url, "GET");
            if (json.Length > 2)
            {
                users = JsonConvert.DeserializeObject<List<User>>(json);
                user = users[0];
            }

            return user;

        }
    }
}