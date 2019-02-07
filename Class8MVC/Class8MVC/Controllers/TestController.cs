using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class8MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public String Quebec(String city, String name = "frank")
        {
            return String.Format("Hello ,{0} from {1}", city, name);
        }
    }
}