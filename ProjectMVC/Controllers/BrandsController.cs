using ProjectMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class BrandsController : Controller
    {
        private ProjectMVCEntities db = new ProjectMVCEntities();

        public ActionResult Index()
        {
            return View(db.Brands.ToList());
        }

        // GET: Brands/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Brands/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Active,")] Brands brands)
        {
            if (ModelState.IsValid)
            {
                db.Brands.Add(brands);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brands);
        }

    }
}