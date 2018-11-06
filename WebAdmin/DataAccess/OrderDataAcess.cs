using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebAdmin.Models;
namespace WebAdmin.DataAccess
{
    public class OrderDataAcess
    {
        public static List<Order> getListOrder()
        {
            string url = "http://" + APIConfig.IpAddress + ":3000/user/getAllUser";
            string json = APIConfig.CallApi(url, "GET");
            List<Order> order = JsonConvert.DeserializeObject<List<Order>>(json);
            return order;
        }
    }
}