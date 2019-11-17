using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public VehiclesController()
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
        [HttpPost]
        public ActionResult Create()
        {
            //ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            ProjectMVC.Logica.BL.TypeServices typeServices1 = new Logica.BL.TypeServices();
            ViewBag.TypeServices = typeServices1.GetTypeService();

            ProjectMVC.Logica.BL.ClassVehicle classVehicle = new ProjectMVC.Logica.BL.ClassVehicle();
            ViewBag.ClassVehicle = classVehicle.GetClassVehicle();

            Logica.BL.Customer customer = new Logica.BL.Customer();
            var CurtomersId = customer.GetCustomer2();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Logica.Models.BindingModels.VehiclesCreateBindingModel model)
        {
            Logica.BL.Customer customer = new Logica.BL.Customer();
            var CurtomersId = customer.GetCustomer2();

            if (ModelState.IsValid)
            {
                Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
                vehicles.CreateVehicles(
                    model.LicensePlate,
                    model.NroTransitLicense,
                    model.StateVehicle,
                    model.TypeServiceId,
                    model.ClassVehicleId,
                    model.Image);

                return RedirectToAction("Index"/*, new { CustomerId = model.CustomerId }*/);
            }

            Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            ViewBag.TypeServices = typeServices.GetTypeService();

            Logica.BL.ClassVehicle classVehicle = new Logica.BL.ClassVehicle();
            ViewBag.ClassVehicle = classVehicle.GetClassVehicle();

            return View(model);
        }
    }
}