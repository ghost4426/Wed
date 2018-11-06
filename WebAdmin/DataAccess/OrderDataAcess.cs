using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebAdmin.Models;
using System.Web;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class OrderDataAcess
    {

        public static List<Order> getOrderDetailByStoreId(int StoreId)
        {
            string url = "http://" + APIConfig.IpAddress + ":3000/order-info/" + StoreId;
            string json = APIConfig.GetReleases(url);
            List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(json);
            return orders;
        }
    }
}