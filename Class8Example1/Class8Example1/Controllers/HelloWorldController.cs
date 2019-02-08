using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8Example1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/Welcome
        //public string Welcome(string name, int id = 1)
        //{
        //    return String.Format("Hello {0}, Number of times {1}", name, id);
        //}


        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = String.Format("Hello from {0}", name);
            ViewBag.NumTimes = numTimes;
            string actionName = RouteData.Values["action"].ToString();

            return View();
        }


       [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get | HttpVerbs.Delete)]
        public ActionResult Test()
        {
            return View();
        }
    }
}