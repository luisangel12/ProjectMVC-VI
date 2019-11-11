using ProjectMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class VehicleGeneralInformationController : Controller
    {
        private ProjectMVCEntities db = new ProjectMVCEntities();

        // GET: VehicleGeneralInformation
        public ActionResult Index()
        {
            return View(db.VehicleGeneralInformation.ToList());
        }

        // GET: VehicleGeneralInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleGeneralInformation/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BrandId,Line,Model,Color,SerialNumber,EngineNumber,ChassisNumber,VIN,Cylinder,TypeBody,TypeFuelId,InitialEnrollmentDate,NroDoors,TypeTireId,AuthoritiesTransitId,VehicleId")] VehicleGeneralInformation vehicleGeneralInformation)
        {
            if (ModelState.IsValid)
            {
                db.VehicleGeneralInformation.Add(vehicleGeneralInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleGeneralInformation);
        }
    }
}
