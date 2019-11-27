using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class VehicleMaintenanceController : Controller
    {
        DAL.Models.ProjectMVCEntities2 db = new DAL.Models.ProjectMVCEntities2();
        private ApplicationUserManager _userManager;


        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set { _userManager = value; }
        }

        public VehicleMaintenanceController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public VehicleMaintenanceController()
        {

        }

        public ActionResult Index()
        {
            Logica.BL.TypeMaintenance typemaintenancev = new Logica.BL.TypeMaintenance();
            ViewBag.TypeMaintenance = typemaintenancev.GetTypeMaintenance();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();


            return View(db.VehicleMaintenances.ToList());
        }



        public ActionResult Create()

        {          

            Logica.BL.TypeMaintenance typemaintenancev = new Logica.BL.TypeMaintenance();
            ViewBag.TypeMaintenance = typemaintenancev.GetTypeMaintenance();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> Create(Logica.Models.BindingModels.VehicleMaintenanceCreateBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            Logica.BL.TypeMaintenance typemaintenancev = new Logica.BL.TypeMaintenance();
            ViewBag.TypeMaintenance = typemaintenancev.GetTypeMaintenance();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();


            if (ModelState.IsValid)
            {
                Logica.BL.VehicleMaintenance vehicleMaintenance = new Logica.BL.VehicleMaintenance();
                vehicleMaintenance.CreateVehicleMantenimiento(model.Id,
                    model.Description,
                    model.MaintenanceDate,
                    model.CurrentMileage,
                    model.NextMaintenanceDate,
                    model.TypeMaintenanceId,
                    model.Amount,
                    model.VehicleId
                    );

                return View("Index");
            }
            return View(model);
        }

    }
}
