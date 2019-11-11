using ProjectMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class AuthoritiesTransitController : Controller
    {
        private ProjectMVCEntities db = new ProjectMVCEntities();

        public ActionResult Index()
        {
            return View(db.AuthoritiesTransit.ToList());
        }

        // GET: AuthoritiesTransit/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: AuthoritiesTransit/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Active,")] AuthoritiesTransit authoritiesTransit)
        {
            if (ModelState.IsValid)
            {
                db.AuthoritiesTransit.Add(authoritiesTransit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(authoritiesTransit);
        }

    }
}