﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CF_Pee.Models;

namespace CF_Pee.Controllers
{
    public class CyclesController : Controller
    {
        private MyStudentsContext db = new MyStudentsContext();

        // GET: Cycles
        public ActionResult Index()
        {
            return View(db.Cycles.ToList());
        }

        // GET: Cycles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cycle cycle = db.Cycles.Find(id);
            if (cycle == null)
            {
                return HttpNotFound();
            }
            return View(cycle);
        }

        // GET: Cycles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cycles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCycle,Name,Period")] Cycle cycle)
        {
            if (ModelState.IsValid)
            {
                db.Cycles.Add(cycle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cycle);
        }

        // GET: Cycles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cycle cycle = db.Cycles.Find(id);
            if (cycle == null)
            {
                return HttpNotFound();
            }
            return View(cycle);
        }

        // POST: Cycles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCycle,Name,Period")] Cycle cycle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cycle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cycle);
        }

        // GET: Cycles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cycle cycle = db.Cycles.Find(id);
            if (cycle == null)
            {
                return HttpNotFound();
            }
            return View(cycle);
        }

        // POST: Cycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cycle cycle = db.Cycles.Find(id);
            db.Cycles.Remove(cycle);
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
