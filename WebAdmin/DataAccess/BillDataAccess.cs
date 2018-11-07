using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class BillDataAccess
    {
        public static List<Bill> getListBillByStoreID(int StoreId)
        {
            string apiRoute = "/bill-info/" + StoreId;
            string json = APIConfig.CallApi(apiRoute, "GET");
            List<Bill> bills = JsonConvert.DeserializeObject<List<Bill>>(json);
            return bills;
        }

    }
}