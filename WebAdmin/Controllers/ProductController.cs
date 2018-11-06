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
            return RedirectToAction("Management");
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

        [HttpPost]
        public ActionResult UpdateProduct(Product product, HttpPostedFileBase file)
        {

            if (file != null)
            {
                string pic = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("~/images/product"), pic);
                file.SaveAs(path);
                product.ImgPath = path;
            }

            ProductDataAcess.UpdateProduct(product);

            return RedirectToAction("Management");

        }

        [HttpPost]
        public ActionResult RemoveProduct(Product product)
        {


            ProductDataAcess.DeleteProduct(product);

            return RedirectToAction("Management");

        }


    }
}