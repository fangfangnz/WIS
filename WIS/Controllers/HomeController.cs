using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WIS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Main form page
        public ActionResult Index()
        {
            ViewBag.welcomeInfo = "Welcome Institute of Studies";
            return View();
        }

        //This a register page
        public ActionResult Register()
        {
            return View();
        }


        //Login Page.
        public ActionResult Login()
        {
            return View();
        }
    }
}