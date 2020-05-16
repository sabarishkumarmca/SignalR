using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST.Models;

namespace TEST.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            Session["ID"] = 1;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetAllData()
        {
            int a = Convert.ToInt32(Session["ID"]) + 1;
            List<Class> list = new List<Class>();
            list.Add(new Class { Id = a });
            return PartialView("_GetAllData", list);
        }
        public ActionResult GetMessages()
        {
            Repository repository = new Repository(); 
            return Json(repository.GetAllMessages(), JsonRequestBehavior.AllowGet);
        }
    }
}