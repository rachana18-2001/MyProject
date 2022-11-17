using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Models;


namespace MyProject.Controllers
{
    public class registrationController : Controller
    {
        // GET: registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Addoredit(int id=0)
        {
            login usermodel = new login();//login model
            return View(usermodel);//pass object into view
        }
        [HttpPost]
        public ActionResult Addoredit(login usermodel)
        {
            using (myDatabaseEntities db = new myDatabaseEntities())
            {
                if (db.login.Any(x=>x.username==usermodel.username))
                {
                    ViewBag.duplicationmessage = "username alraedy exists";
                    return View("Addoredit",usermodel);
                }
                db.login.Add(usermodel);
                db.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Suceesful";
            return View("Addoredit", new login());

        }
        /// <summary>
        /// function used to move from login to register page
        /// </summary>
        /// <returns></returns>
        public ActionResult register()
        {
            return RedirectToAction("Addoredit", "registration");
        }
    }
}