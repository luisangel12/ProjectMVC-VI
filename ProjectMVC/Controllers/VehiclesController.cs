using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    [Authorize]
    public class VehiclesController : Controller
    {
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set { _userManager = value; }
        }

        public VehiclesController ()
        {


        }

        public ActionResult Index()
        {
            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            var listVehicles = vehicles.GetVehicles();

            var listVehiclesViewModel = listVehicles.Select(x => new Logica.Models.ViewModels.VehiclesViewModel
            {
                Id = x.Id,
                LicensePlate = x.LicensePlate,
                NroTransitLicense = x.NroTransitLicense,
                StateVehicle = x.StateVehicle,
                TypeServiceId = x.TypeServiceId,
                ClassVehicleId = x.ClassVehicleId,
                Image = x.Image,
                CustomerId = x.CustomerId
            }).ToList();

            Logica.BL.Vehicles vehicles1 = new Logica.BL.Vehicles();
            //var vehicles = vehicles.GetVehicles().FirstOrDefault();

            ViewBag.Vehicles = vehicles;

            return View(listVehiclesViewModel);
        }

        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Create(Logica.Models.BindingModels.VehiclesCreateBindingModel model)
        {
            if (ModelState.IsValid)
            {
                Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
                vehicles.CreateVehicles(model.Id,
                    model.LicensePlate,
                    model.NroTransitLicense,
                    model.StateVehicle,
                    model.TypeServiceId,
                    model.ClassVehicleId,
                    model.Image,
                    model.CustomerId);

                return RedirectToAction("Index");
            }

            //Logica.BL.States states = new Logica.BL.States();
            //ViewBag.States = states.GetStates();

            //Logica.BL.Activities activities = new Logica.BL.Activities();
            //ViewBag.Activities = activities.GetActivities();

            //Logica.BL.Priorities priorities = new Logica.BL.Priorities();
            //ViewBag.Priorities = priorities.GetPriorities();

            return View(model);
        }
    }
}