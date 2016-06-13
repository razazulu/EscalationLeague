using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
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
        public ActionResult Create([Bind(Include = "ID,Title,DateCreated,MainFaction,SubFaction,PointTotal")] ArmyList armyList)
        {
            if (ModelState.IsValid)
            {
                db.ArmyLists.Add(armyList);
                db.SaveChanges();
                return RedirectToAction("Index");
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,DateCreated,MainFaction,SubFaction,PointTotal")] ArmyList armyList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(armyList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(armyList);
        }

        // GET: ArmyLists/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: ArmyLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArmyList armyList = db.ArmyLists.Find(id);
            db.ArmyLists.Remove(armyList);
            db.SaveChanges();
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
