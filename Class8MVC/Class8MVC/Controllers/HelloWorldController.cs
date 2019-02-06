using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public String Index()
        {
            return "This is my <b>Index</b> action ...";
        }

        //GET: HelloWorld/Welcome
        /*
        public String Welcome(String name, int numTimes = 1)
        {
            return String.Format("Hello {0}, Number of times is {1}",name,numTimes);
        }
        */
        
        public ActionResult Welcome(string name, int numTimes =1)
        {
            ViewBag.Message = String.Format("Hello from {0}", name);
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}