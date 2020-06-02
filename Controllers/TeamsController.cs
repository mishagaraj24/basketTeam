using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data.Entity;
using basKet.Models;
using basKet.Data;
using System.Xml.Linq;

namespace basket.Controllers
{
    public class TeamsController : Controller
    {
        Teams db = new basKet.Data.Teams();
        public ActionResult Index()
        {
            return View(db.Comandi);
        }
      
        public ActionResult Details(int id)
        {
            Comanda team = db.Comandi.Find(id);
            if (team != null)
            {
                return PartialView("Details", team);
            }
            return View("Index");
        }
        
        public ActionResult Create()
        {
            return PartialView("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comanda team)
        {
            db.Comandi.Add(team);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Редактирование
        public ActionResult Edit(int id)
        {
            Comanda team = db.Comandi.Find(id);
            if (team != null)
            {
                return PartialView("Edit", team);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(basKet.Models.Comanda team)
        {
            db.Entry(team).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Удаление
        public ActionResult Delete(int id)
        {
            Comanda team = db.Comandi.Find(id);
            if (team != null)
            {
                return PartialView("Delete", team);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int id)
        {
            Comanda team = db.Comandi.Find(id);

            if (team != null)
            {
                db.Comandi.Remove(team);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}