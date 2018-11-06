using System.Web.Mvc;
using WebAdmin.DataAccess;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
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
            ViewData["TableList"] = TableDataAccess.getListTableByStoreId(1);
            return View("Management");
        }

        [HttpPost]
        public ActionResult AddNewTable(Table table)
        {

            TableDataAccess.NewTable(table, 1);
            return View("AddNew");

        }

        [HttpPost]
        public ActionResult UpdateTable(Table table)
        {

            TableDataAccess.UpdateTable(table);

            return RedirectToAction("Management");

        }

        [HttpPost]
        public ActionResult RemoveTable(Table table)
        {

            return RedirectToAction("Management");

        }
    }
}