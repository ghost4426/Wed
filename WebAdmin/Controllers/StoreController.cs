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
            List<Store> test = StoreDataAcess.getListStore();

            Console.WriteLine(test);
            ViewData["StoreList"] = StoreDataAcess.getListStore();

            return View("Management");
        }


        [HttpPost]
        public ActionResult AddNewStore(Store store)
        {


            StoreDataAcess.addStore(store);

            return RedirectToAction("Management");
        }

        [HttpPost]
        public ActionResult UpdateStore(Store store)
        {


            StoreDataAcess.updateStore(store);

            return RedirectToAction("Management");
        }


        [HttpPost]
        public ActionResult RemoveStore(Store store)
        {

            StoreDataAcess.deleteStore(store);

            return RedirectToAction("Management");
        }
    }
}