using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class OrderDataAcess
    {
        public static List<Order> getOrderDetailByStoreId(int StoreId)
        {
            string url = "/order-info/" + StoreId;
            string json = APIConfig.CallApi(url, "GET");
            List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(json);
            return orders;
        }
    }
}