using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Controllers;
using MyProject.Models;
//using System.Data.EntityState;

namespace MyProject.Controllers
{
    public class grivenceController : Controller
    {
        // GET: grivence
        public ActionResult Index()
        {
            using (dbmodel db = new dbmodel())
            {
                return View(db.grivences.ToList()); 
            }
        }

        // GET: grivence/Details/5
        public ActionResult Details(int id)
        {
            using (dbmodel db =new dbmodel())
            {
                return View(db.grivences.Where(x=>x.Id==id).FirstOrDefault());
            }
           
        }

        // GET: grivence/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: grivence/Create
        [HttpPost]
        public ActionResult Create(grivence griv)
        {
            try
            {
                using (dbmodel db = new dbmodel())
                {
                    db.grivences.Add(griv);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: grivence/Edit/5
        public ActionResult Edit(int id)
        {
            using (dbmodel db = new dbmodel())
            {
                return View(db.grivences.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: grivence/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, grivence grivence)
        {
            try
            {
                // TODO: Add update logic here
                using (dbmodel db = new dbmodel())
                {
                    db.Entry(grivence).State=EntityState .Modified;
                    db.SaveChanges();
                    
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: grivence/Delete/5
        public ActionResult Delete(int id)
        {
            using (dbmodel db = new dbmodel())
            {
                return View(db.grivences.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: grivence/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (dbmodel db = new dbmodel())
                {
                    grivence griv=db.grivences.Where(X=>X.Id == id).FirstOrDefault();
                    db.grivences.Remove(griv);
                    db.SaveChanges();


                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
