using ProjectMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class TypeFuelsController : Controller
    {
        private ProjectMVCEntities db = new ProjectMVCEntities();

        public ActionResult Index()
        {
            return View(db.TypeFuels.ToList());
        }

        // GET: TypeFuels/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: TypeFuels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Active,")] TypeFuels typeFuels)
        {
            if (ModelState.IsValid)
            {
                db.TypeFuels.Add(typeFuels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeFuels);
        }

    }
}