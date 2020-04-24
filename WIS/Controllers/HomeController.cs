using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/** 
 * Author: Qifeng Fang
 * Create Date: 01/04/2020
 * Update Date: 18/04/2020 
 * Method name has changed. Follow the guideline,start the lowercase letter.
 * 
 * */
namespace WIS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Main form page
        public ActionResult index(){ //Brackets follow the guidelines.
        
            ViewBag.welcomeInfo = "Welcome Institute of Studies";
            return View();
        }

        //This a register page
        public ActionResult register(){
        
            return View();
        }


        //Login Page.
        public ActionResult login(){
        
            return View();
        }
    }
}