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

        public static List<Order> getListOrder(int storeId)
        {
            string url = "/order/" + storeId;
            string json = APIConfig.CallApi(url, "GET");
            List<Order> order = JsonConvert.DeserializeObject<List<Order>>(json);
            for (int i = 0; i < order.Count; i++)
            {
                if (order.ElementAt(i).Status == "1")
                {
                    order.ElementAt(i).Status = "Done";
                }
                else
                {
                    order.ElementAt(i).Status = "Hủy";
                }

            }

            return order;
        }
        public static List<Order> getListOrderDetail(int orderId)
        {
            string url = "/order-detail/" + orderId;
            string json = APIConfig.CallApi(url, "GET");
            List<Order> order = JsonConvert.DeserializeObject<List<Order>>(json);

            return order;
        }

        public static Order getOrderByOrderId(int orderId)
        {
            string apiRoute = "/getOrder/" + orderId;
            string json = APIConfig.CallApi(apiRoute, "GET");
            List<Order> order = JsonConvert.DeserializeObject<List<Order>>(json);
            return order[0];
        }
    }
}