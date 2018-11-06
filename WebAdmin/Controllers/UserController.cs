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

            APIConfig.CallApi("http://127.0.0.1:3000/bills/3&3&3", "POST");
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();

            string text = APIConfig.CallApi("http://127.0.0.1:3000/user/getAllUser", "GET");
            List<User> test = UserDataAcess.getListUser();

            Console.WriteLine(test);
            ViewData["UserList"] = test; 
           
            return View("Management");
        }

   

        [HttpPost]
        public ActionResult AddNewUser(User user, string Password)
        {

            String userName = user.Username;
            String fullName = user.FullName;
            String address = user.Address;
            String passWord = Password;

            return RedirectToAction("Management");
        }

    }
}