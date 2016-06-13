using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EscalationLeague.DAL;
using EscalationLeague.Models;

namespace EscalationLeague.Controllers
{
    public class ArmyListsController : Controller
    {
        private ArmyListDBContext db = new ArmyListDBContext();

        // GET: ArmyLists
        public ActionResult Index()
        {
            return View(db.ArmyLists.ToList());
        }

        // GET: ArmyLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArmyList armyList = db.ArmyLists.Find(id);
            if (armyList == null)
            {
                return HttpNotFound();
            }
            return View(armyList);
        }

        // GET: ArmyLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArmyLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,DateCreated,Verified")] ArmyList armyList)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.ArmyLists.Add(armyList);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException /*dex*/)
            {
                //Log the error, uncomment dex and add it to log
                ModelState.AddModelError("", "Unable to save changes. Try again, if the problem persists contact your system administrator.");
                
            }

            return View(armyList);
        }

        // GET: ArmyLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArmyList armyList = db.ArmyLists.Find(id);
            if (armyList == null)
            {
                return HttpNotFound();
            }
            return View(armyList);
        }

        // POST: ArmyLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var armyListToUpdate = db.ArmyLists.Find(id);
            if (TryUpdateModel(armyListToUpdate, "", new string[] {"Title", "DateCreated", "Verified"}))
            {
                try
                {
                    db.SaveChanges();
                }
                catch(DataException /*dex*/)
                {
                    //dex for logging exceptions
                    ModelState.AddModelError("", "Unable to save changes. Try again, if the problem persists contact your system administrator.");
                }
            }
            return RedirectToAction("Index");
        }

        // GET: ArmyLists/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError=false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            ArmyList armyList = db.ArmyLists.Find(id);
            if (armyList == null)
            {
                return HttpNotFound();
            }
            return View(armyList);
        }

        // POST: ArmyLists/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ArmyList armyList = db.ArmyLists.Find(id);
                db.ArmyLists.Remove(armyList);
                db.SaveChanges();
            }
            catch (DataException /*dex*/)
            {
                //dex for logging
                return RedirectToAction("Delete", new {id = id, SaveChangError = true});
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
