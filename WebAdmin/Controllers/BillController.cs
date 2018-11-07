using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdmin.DataAccess;

namespace WebAdmin.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        public ActionResult Index()
        {

            ViewData["BillsList"] = BillDataAccess.getListBillByStoreID(1);
            return View("Management");
        }
    }
}