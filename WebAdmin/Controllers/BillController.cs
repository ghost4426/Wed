using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdmin.DataAccess;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class BillController : Controller
    {

        // GET: Bill
        public ActionResult Index()
        {
            User UserCurrent = Session["UserCurrent"] as User;
            ViewData["BillsList"] = BillDataAccess.getListBillByStoreID(UserCurrent.StoreId);
            return View("Management");
        }

        [HttpPost]
        public ActionResult Detail(int BillId)
        {
            ViewData["Bill"] = BillDataAccess.getBillByBillId(BillId);
            ViewData["BillDetails"] = BillDataAccess.getListBillDetailByBillId(BillId);
            return View("Detail");
        }
    }
}