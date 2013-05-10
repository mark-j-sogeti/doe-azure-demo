using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListApp.Models;

namespace ToDoListApp.Controllers
{
    public class HomeController : Controller
    {
        private ToDoDb db = new ToDoDb();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.ToDoItems.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            ToDoItem todoitem = db.ToDoItems.Find(id);
            if (todoitem == null)
            {
                return HttpNotFound();
            }
            return View(todoitem);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDoItem todoitem)
        {
            if (ModelState.IsValid)
            {
                db.ToDoItems.Add(todoitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todoitem);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ToDoItem todoitem = db.ToDoItems.Find(id);
            if (todoitem == null)
            {
                return HttpNotFound();
            }
            return View(todoitem);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ToDoItem todoitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(todoitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todoitem);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ToDoItem todoitem = db.ToDoItems.Find(id);
            if (todoitem == null)
            {
                return HttpNotFound();
            }
            return View(todoitem);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToDoItem todoitem = db.ToDoItems.Find(id);
            db.ToDoItems.Remove(todoitem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}