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

            List<Store> test = StoreDataAcess.getListStore();
            ViewData["StoreList"] = test;
            return View("AddNew");

        }
        public ActionResult Management()
        {



            List<User> test = UserDataAcess.getListUser();

            ViewData["UserList"] = test;
            ViewData["StoreList"] = StoreDataAcess.getListStore();
           
            return View("Management");
        }

   

        [HttpPost]
        public ActionResult AddNewUser(User user, string Password)
        {

            String userName = user.Username;
            String fullName = user.FullName;
            String address = user.Address;
            String passWord = Password;
            int storeId = user.StoreId;
            int roleId = 2;

            UserDataAcess.addUser(userName, fullName, address, storeId, roleId, passWord);


            return RedirectToAction("Management");
        }


        [HttpPost]
        public ActionResult UpdateUser(User user)
        {

            UserDataAcess.updateUser(user);
            return RedirectToAction("Management");
        }

        [HttpPost]
        public ActionResult RemoveUser(User user)
        {
            UserDataAcess.deleteUser(user);
            return RedirectToAction("Management");
        }


    }
}