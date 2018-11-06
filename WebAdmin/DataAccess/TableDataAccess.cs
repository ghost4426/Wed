using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class TableDataAccess
    {
        public static List<Table> getListTableByStoreId(int StoreId)
        {
            string url = "/tablelist/" + StoreId;
            string json = APIConfig.CallApi(url, "GET");
            List<Table> tables = JsonConvert.DeserializeObject<List<Table>>(json);
            return tables;
        }


        public static bool UpdateTable(Table table)
        {
            string apiRoute = "/updatetable/"
                                            + table.TableName
                                + "&" + table.TableId
                                + "&" + table.IsAvailable;

            APIConfig.CallApi(apiRoute, "POST");
            return true;
        }
        public static bool NewTable(Table table, int StoreId)
        {
            table.TableKey = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            string apiRoute = "/addtable/"
                                           + StoreId
                               + "&" + table.TableKey
                               + "&" + table.TableName;

            APIConfig.CallApi(apiRoute, "POST");
            return true;
        }
    }
}