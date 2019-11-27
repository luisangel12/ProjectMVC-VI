using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class VehicleTechnicalDataController : Controller
    {
        // GET: VehicleTechnicalData
        public ActionResult Index()
        {
            return View();
        }

        // GET: VehicleTechnicalData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleTechnicalData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleTechnicalData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleTechnicalData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleTechnicalData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleTechnicalData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleTechnicalData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
