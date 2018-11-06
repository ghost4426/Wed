using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebAdmin.Models;
using Service;
namespace WebAdmin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View("Management");
        }

        public ActionResult AddNew() { 
            return View("AddNew");

        }
        public ActionResult Management()
        {
            return View("Management");
        }

   

        [HttpPost]
        public ActionResult AddNewUser(User user, string Password)
        {
            string fullname = user.FullName;
            string address = user.Address;
            string store = user.Store;
            string username = user.Username;
            string password = user.Password;


            UserDataAccess.GetReleases("http://127.0.0.1:3000/bills/3&3&3","POST");
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();

            string text = UserDataAccess.GetReleases("http://127.0.0.1:3000/user/getAllUser","GET");
            List<User> test = json_serializer.Deserialize<List<User>>(text);
    
            return RedirectToAction("Management");
        }

        [HttpPost]
        public ActionResult delete(User user)
        {
            string fullname = user.FullName;
            string address = user.Address;
            string store = user.Store;
            string username = user.Username;
            string password = user.Password;


            UserDataAccess.PostReleases("http://127.0.0.1:3000/bills/3&3&3");
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();

            string text = UserDataAccess.GetReleases("http://127.0.0.1:3000/user/getAllUser");
            List<User> test = json_serializer.Deserialize<List<User>>(text);

            return RedirectToAction("Management");
        }


    }
}