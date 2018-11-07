﻿using System;
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
            User UserCurrent = Session["UserCurrent"] as User;
            ViewData["OrdersList"] = OrderDataAcess.getOrderDetailByStoreId(UserCurrent.StoreId);

            return View("Management");
        }
    }
}