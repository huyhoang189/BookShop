using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_first.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
       // public ActionResult Index()
        //{
         //   return View();
        //}
        public ActionResult Index()
        {
            DateTime a = DateTime.Now;
            return View();
        }
        public string Hello()
        {
            return "Hello world";
        }
        public string showName_Age(string name ="Hoang", int age = 1)
        {
            return HttpUtility.HtmlEncode("Xiin chao " + name + " tuoui " + age);
        }
    }
}