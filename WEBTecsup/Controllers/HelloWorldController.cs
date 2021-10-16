using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBTecsup.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index(string Name,string LastName)
        {
            ViewBag.FullName = string.Concat(Name, " ", LastName);

            return View();
        }
        public string Welcome(int Edad)
        {            
            return "<h1>Welcome to Tecsup </h1>"+ Edad.ToString();
        }
    }
}