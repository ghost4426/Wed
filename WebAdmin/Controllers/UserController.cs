using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
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

        [HttpPost]
        public ActionResult AddNewUser(User user, string Password)
        {
            return RedirectToAction("UserManagement");
        }


    }
}