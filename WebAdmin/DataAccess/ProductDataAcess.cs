using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class ProductDataAcess
    {

        public static List<Product> getListProductByStoreID(int StoreId)
        {
            string url = "http://"+ APIConfig.IpAddress + ":3000/products-store/" + StoreId;
            string json = APIConfig.GetReleases(url);
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }
    }
}