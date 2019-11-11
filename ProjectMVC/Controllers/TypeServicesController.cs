using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using ProjectMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    [Authorize]
    public class TypeServicesController : Controller
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

        public TypeServicesController()
        {


        }

        public ActionResult Index()
        {
            Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            var listTypeServices = typeServices.GetTypeServices();

            var listTypeServicesViewModel = listTypeServices.Select(x => new Logica.Models.ViewModels.TypeServicesViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Active = x.Active
            }).ToList();

            Logica.BL.TypeServices typeServices1 = new Logica.BL.TypeServices();
            //var typeServices = typeServices.GetTypeServices().FirstOrDefault();

            ViewBag.TypeServices = typeServices;

            return View(listTypeServicesViewModel);
        }

        public ActionResult Create()
        {


            return View();
        }


        [HttpPost]
        public ActionResult Create(Logica.Models.BindingModels.TypeServicesCreateBindingModel model)
        {
            if (ModelState.IsValid)
            {
                Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
                typeServices.CreateTypeServices(model.Id,
                    model.Name,
                    model.Active);

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