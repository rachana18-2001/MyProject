using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usermodel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult autherize(MyProject.Models.login usermodel)
        {
            using (myDatabaseEntities db=new myDatabaseEntities())//object for database
            {
                var userdetails=db.login.Where( x =>x.username==usermodel.username && x.password==usermodel.password).FirstOrDefault();//comparing the data
                if (userdetails==null) {
                    usermodel.loginerrormessage = "wrong username or password";//error message
                    return View("Index",usermodel);
                }
                else
                {
                    Session["userid"] = userdetails.userid;
                    Session["username"] = userdetails.username;
                    return RedirectToAction("Index", "grivence");//goes to home page
                }

            }
            
        }
        /// <summary>
        /// function used to move from home to login page
        /// </summary>
        /// <returns></returns>
        public ActionResult logout()
        {
            int userid = (int)Session["userid"];
            Session.Abandon();
            return RedirectToAction("Index", "login");//goes to login page
        }
        /// <summary>
        /// function used to move from register to login page
        /// </summary>
        /// <returns></returns>
        public ActionResult backtologin()
        {
          
            return RedirectToAction("Index", "login");//goes to login page
        }

    }
}