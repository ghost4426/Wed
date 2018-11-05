using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAdmin.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View("Management");
        }

        public ActionResult AddNew()
        {
            return View("AddNew");
        }
        public ActionResult Management()
        {
            return View("Management");
        }
    }
}