using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nameless_Store.Models;

namespace Nameless_Store.Controllers
{
    public class NamelessStoreCartController : Controller
    {
        private Nameless_StoreContext db = new Nameless_StoreContext();

        // GET: NamelessStoreCRUD
        public ActionResult Index()
        {
            return View(db.NamelessStoreModels.ToList());
        }

        // GET: NamelessStoreCRUD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamelessStoreModel namelessStoreModel = db.NamelessStoreModels.Find(id);
            if (namelessStoreModel == null)
            {
                return HttpNotFound();
            }
            return View(namelessStoreModel);
        }

        // GET: NamelessStoreCRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NamelessStoreCRUD/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Price")] NamelessStoreModel namelessStoreModel)
        {
            if (ModelState.IsValid)
            {
                db.NamelessStoreModels.Add(namelessStoreModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(namelessStoreModel);
        }

        // GET: NamelessStoreCRUD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamelessStoreModel namelessStoreModel = db.NamelessStoreModels.Find(id);
            if (namelessStoreModel == null)
            {
                return HttpNotFound();
            }
            return View(namelessStoreModel);
        }

        // POST: NamelessStoreCRUD/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Price")] NamelessStoreModel namelessStoreModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(namelessStoreModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(namelessStoreModel);
        }

        // GET: NamelessStoreCRUD/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamelessStoreModel namelessStoreModel = db.NamelessStoreModels.Find(id);
            if (namelessStoreModel == null)
            {
                return HttpNotFound();
            }
            return View(namelessStoreModel);
        }

        // POST: NamelessStoreCRUD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NamelessStoreModel namelessStoreModel = db.NamelessStoreModels.Find(id);
            db.NamelessStoreModels.Remove(namelessStoreModel);
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
