using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RobotReviewSite1._0.Models;

namespace RobotReviewSite1._0.Controllers
{
    public class RobotsController : Controller
    {
        private RobotReviewSite1_0Context db = new RobotReviewSite1_0Context();

        // GET: Robots
        public ActionResult Index()
        {
            var robots = db.Robots.Include(r => r.Category);
            return View(robots.ToList());
        }

        // GET: Robots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Robot robot = db.Robots.Find(id);
            if (robot == null)
            {
                return HttpNotFound();
            }
            return View(robot);
        }

        // GET: Robots/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Function");
            return View();
        }

        // POST: Robots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RobotID,Name,FirstAppearsIn,CreatedBy,IsGood,IsEvil,CategoryID")] Robot robot)
        {
            if (ModelState.IsValid)
            {
                db.Robots.Add(robot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Function", robot.CategoryID);
            return View(robot);
        }

        // GET: Robots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Robot robot = db.Robots.Find(id);
            if (robot == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Function", robot.CategoryID);
            return View(robot);
        }

        // POST: Robots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RobotID,Name,FirstAppearsIn,CreatedBy,IsGood,IsEvil,CategoryID")] Robot robot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(robot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Function", robot.CategoryID);
            return View(robot);
        }

        // GET: Robots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Robot robot = db.Robots.Find(id);
            if (robot == null)
            {
                return HttpNotFound();
            }
            return View(robot);
        }

        // POST: Robots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Robot robot = db.Robots.Find(id);
            db.Robots.Remove(robot);
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
