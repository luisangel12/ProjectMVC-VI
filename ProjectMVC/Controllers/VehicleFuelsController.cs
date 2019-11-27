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
    public class VehicleFuelsController : Controller
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

        public VehicleFuelsController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public VehicleFuelsController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Create()
        {
            Logica.BL.TypeFuels typeFuels = new Logica.BL.TypeFuels();
            ViewBag.TypeFuels = typeFuels.GetTypeFuels();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Logica.Models.BindingModels.VehicleFuelsCreateBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            Logica.BL.TypeFuels typeFuels = new Logica.BL.TypeFuels();
            ViewBag.TypeFuels = typeFuels.GetTypeFuels();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();
            

            if (ModelState.IsValid)
            {
                Logica.BL.VehicleFuels vehicleFuels = new Logica.BL.VehicleFuels();
                vehicleFuels.CreateVehicleFuel(
                    model.TypeFuelId,
                    model.Amount,
                    model.LiterFuel,
                    model.VehicleId
                    );

                return View("Index");
            }
            return View(model);
        }

        //public ActionResult Edit(int? id)
        //{
        //    Logica.BL.VehicleFuels projects = new Logica.BL.VehicleFuels();
        //    var project = projects.GetProjects(id, null).FirstOrDefault();

        //    var projectBindingModel = new Logica.Models.BindingModels.ProjectsCreateBindingModel
        //    {
        //        Id = project.Id,
        //        Details = project.Details,
        //        ExpectedCompletionDate = project.ExpectedCompletionDate,
        //        Title = project.Title
        //    };

        //    return View(projectBindingModel);
        //}

        //[HttpPost]
        //public ActionResult Edit(Logica.Models.BindingModels.ProjectsCreateBindingModel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            Logica.BL.VehicleFuels projects = new Logica.BL.VehicleFuels();

        //            projects.UpdateProjects(
        //                model.Id,
        //                model.Title,
        //                model.Details,
        //                model.ExpectedCompletionDate);
        //        }
        //        else
        //        {
        //            return Json(new Logica.Models.ViewModels.ResponseViewModel
        //            {
        //                IsSuccessful = false,
        //                Errors = ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList()
        //            }, JsonRequestBehavior.AllowGet);
        //        }

        //        return Json(new
        //        {
        //            IsSuccessful = true
        //        }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new Logica.Models.ViewModels.ResponseViewModel
        //        {
        //            IsSuccessful = false,
        //            Errors = new List<string> { ex.Message }
        //        }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //public ActionResult Details(int? id)
        //{

        //    ViewBag.ProjectId = id;

        //    return View();
        //}

        //public ActionResult GetProject(int? id)
        //{
        //    try
        //    {
        //        Logica.BL.VehicleFuels projects = new Logica.BL.VehicleFuels();
        //        var project = projects.GetProjects(id, null).FirstOrDefault();

        //        var projectDetailsViewModel = new Logica.Models.ViewModels.ProjectsDetailsViewModel
        //        {
        //            Details = project.Details,
        //            ExpectedCompletionDateString = project.ExpectedCompletionDate == null ? string.Empty : project.ExpectedCompletionDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
        //            Title = project.Title,
        //            CreatedAtString = project.CreatedAt == null ? string.Empty : project.CreatedAt.Value.ToString("yyyy-MM-dd HH:mm:ss"),
        //            UpdatedAtString = project.UpdatedAt == null ? string.Empty : project.UpdatedAt.Value.ToString("yyyy-MM-dd HH:mm:ss")
        //        };

        //        return Json(new
        //        {
        //            IsSuccessful = true,
        //            Data = projectDetailsViewModel
        //        }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new Logica.Models.ViewModels.ResponseViewModel
        //        {
        //            IsSuccessful = false,
        //            Errors = new List<string> { ex.Message }
        //        }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //public ActionResult Delete(int? id)
        //{
        //    Logica.BL.VehicleFuels projects = new Logica.BL.VehicleFuels();
        //    projects.DeleteProjects(id);

        //    return RedirectToAction("Index");
        //}
    }
}