using Datatables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Datatables.Controllers
{
    public class MVCController : Controller
    {
        // GET: MVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            DataTableEntities db = new DataTableEntities();
            var data = db.mvcs.OrderBy(a => a.Name).ToList();
            return Json(new {data=data},JsonRequestBehavior.AllowGet);
        }
    }
}