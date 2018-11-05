using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdmin.DataAccess;

namespace WebAdmin.Controllers
{
    public class ProductController : Controller
    {


        // GET: Product
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
            ViewData["ProdutsList"] = ProductDataAcess.getListProductByStoreID(1);
            return View("Management");
        }
    }
}