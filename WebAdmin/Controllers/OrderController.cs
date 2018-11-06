using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdmin.DataAccess;

namespace WebAdmin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View("Management");
        }

        
        public ActionResult Management()
        {
            ViewData["OrdersList"] = OrderDataAcess.getOrderDetailByStoreId(1);
            return View("Management");
        }
    }
}