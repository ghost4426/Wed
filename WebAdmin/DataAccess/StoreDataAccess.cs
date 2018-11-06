using Newtonsoft.Json;
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
    public class StoreDataAcess
    {

        public static List<Store> getListStore()
        {
            string url = "http://" + APIConfig.IpAddress + ":3000/store/getAllStore";
            string json = APIConfig.CallApi(url, "GET");
            List<Store> store = JsonConvert.DeserializeObject<List<Store>>(json);
            return store;
        }
    }
}