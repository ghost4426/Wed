using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdmin.DataAccess;
using WebAdmin.Models;

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
            ViewData["ProdutsList"] = ProductDataAcess.GetListProductByStoreID(1);
            return View("Management");
        }

        [HttpPost]
        public ActionResult AddNewProduct(Product product, HttpPostedFileBase file)
        {

            if (file != null)
            {
                string pic = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("~/images/product"), pic);
                file.SaveAs(path);
                product.ImgPath = path;
                ProductDataAcess.AddNewProduct(product, 1);
                ViewBag.msg = "Success";
            }

            return View("AddNew");

        }
    }
}