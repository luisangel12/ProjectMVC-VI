using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{

    public class VehicleTechnicalDataController : Controller
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

        public VehicleTechnicalDataController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public VehicleTechnicalDataController()
        {

        }

        public ActionResult Index()
        {
            //Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            //ViewBag.TypeService = typeServices.GetTypeServices();

            //Logica.BL.ClassVehicle classVehicle = new Logica.BL.ClassVehicle();
            //ViewBag.ClassVehicle = classVehicle.GetClassVehicle();


            return View();
        }



        public ActionResult Create()
        {
            //Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            //ViewBag.TypeService = typeServices.GetTypeServices();

            //Logica.BL.ClassVehicle classVehicle = new Logica.BL.ClassVehicle();
            //ViewBag.ClassVehicle = classVehicle.GetClassVehicle();

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> Create(Logica.Models.BindingModels.VehiclesCreateBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            //Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            //ViewBag.TypeService = typeServices.GetTypeServices();

            //Logica.BL.ClassVehicle classVehicle = new Logica.BL.ClassVehicle();
            //ViewBag.ClassVehicle = classVehicle.GetClassVehicle();

            if (ModelState.IsValid)
            {
 
                //Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();


                //var capturaVehicles = vehicles.GetVehicles2().Where(x => x.Id == user.Id).FirstOrDefault();

                //Logica.BL.VehicleTechnicalData vehicletechnicaldata = new Logica.BL.VehicleTechnicalData();
                //vehicletechnicaldata.CreateVehicleTechnicalData(model.Id,
                //    model.CapacityLoad,
                //    model.PassengerCapacity,
                //    model.GVWR,
                //    model.CapacityPassengersSitting,
                //    model.NumberAxes,
                //    capturaVehicles.Id
                //    );

                //return View("Create");

            }
            return View(model);
        }

    }
}
