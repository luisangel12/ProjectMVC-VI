using ProjectMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class VehicleTechnicalDataController : Controller
    {
        private ProjectMVCEntities2 db = new ProjectMVCEntities2();

        // GET: VehicleTechnicalData
        public ActionResult Index()
        {
            return View(db.VehicleTechnicalDatas.ToList());
        }

        // GET: VehicleTechnicalData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleTechnicalData/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CapacityLoad,PassengerCapacity,GVWR,CapacityPassengersSitting,NumberAxes,VehicleId")] VehicleTechnicalData vehicleTechnicalData)
        {
            if (ModelState.IsValid)
            {
                db.VehicleTechnicalDatas.Add(vehicleTechnicalData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleTechnicalData);
        }
    }
}
