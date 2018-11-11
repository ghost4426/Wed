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

        public static List<BillDetail> getListBillDetailByBillId(int BillId)
        {
            string apiRoute = "/billdetail/" + BillId;
            string json = APIConfig.CallApi(apiRoute, "GET");
            List<BillDetail> bills = JsonConvert.DeserializeObject<List<BillDetail>>(json);
            return bills;
        }

        public static Bill getBillByBillId(int BillId)
        {
            string apiRoute = "/getBill/" + BillId;
            string json = APIConfig.CallApi(apiRoute, "GET");
            List<Bill> bill = JsonConvert.DeserializeObject<List<Bill>>(json);
            return bill[0];
        }

    }
}