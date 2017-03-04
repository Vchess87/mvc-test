using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {  
        [HttpGet]
        public ActionResult Test()
        {
            return this.View();
        }
        
        [HttpPost]
        public ActionResult Test(TestViewModel test)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(test);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult GetTest()
        {
            return this.Json(new { d =  new List<string>() { "test1", "test2" } }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            //throw new Exception();

            ApplicationDbContext context = new ApplicationDbContext();
            var count = context.Users.Count();
            Session["test"] = "test2;";
            
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
        
        public ActionResult Test(string arg1, string arg2)
        {
            return new JsonResult() { Data = new { test = "test"  }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}