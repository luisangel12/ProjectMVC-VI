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


            return View(db.VehicleMaintenances.ToList());
        }



        public async Task<ActionResult> Create()

        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);



            Logica.BL.TypeMaintenance typemaintenancev = new Logica.BL.TypeMaintenance();
            ViewBag.TypeMaintenance = typemaintenancev.GetTypeMaintenance();

    

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> Create(Logica.Models.BindingModels.VehicleMaintenanceCreateBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);
            Logica.BL.Vehicles vehicles1 = new Logica.BL.Vehicles();

            var capturaVehiculo = vehicles1.GetVehicles(user.Id, null).FirstOrDefault();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();

            ViewBag.Vehicle = vehicles.GetVehicles(capturaVehiculo.Id);

            Logica.BL.TypeMaintenance typemaintenancev = new Logica.BL.TypeMaintenance();
            ViewBag.TypeMaintenance = typemaintenancev.GetTypeMaintenance();


            if (ModelState.IsValid)
            {

                var ImageVehicle = string.Empty;

              


            }
            return View(model);
        }

    }
}
