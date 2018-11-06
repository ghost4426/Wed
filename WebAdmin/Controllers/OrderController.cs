using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebAdmin.Models;
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
            List<Order> test = OrderDataAcess.getListOrder();

            Console.WriteLine(test);
            ViewData["OrderList"] = OrderDataAcess.getListOrder();
            return View("Management");
        }
    }
}