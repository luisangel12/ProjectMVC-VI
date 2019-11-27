using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{

    public class VehicleGeneralInformationController : Controller
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

        public VehicleGeneralInformationController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public VehicleGeneralInformationController()
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

            Logica.BL.AuthoritiesTransit authoritiesTransit = new Logica.BL.AuthoritiesTransit();
            ViewBag.AuthoritiesTransit = authoritiesTransit.GetAuthoritiesTransit();

            Logica.BL.Brands brands = new Logica.BL.Brands();
            ViewBag.Brands = brands.GetBrands();

            Logica.BL.TypeTires typeTires = new Logica.BL.TypeTires();
            ViewBag.TypeTires = typeTires.GetTypeTires();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> Create(Logica.Models.BindingModels.VehicleGeneralInformationCreateBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            Logica.BL.TypeFuels typeFuels = new Logica.BL.TypeFuels();
            ViewBag.TypeFuels = typeFuels.GetTypeFuels();

            Logica.BL.AuthoritiesTransit authoritiesTransit = new Logica.BL.AuthoritiesTransit();
            ViewBag.AuthoritiesTransit = authoritiesTransit.GetAuthoritiesTransit();

            Logica.BL.Brands brands = new Logica.BL.Brands();
            ViewBag.Brands = brands.GetBrands();

            Logica.BL.TypeTires typeTires = new Logica.BL.TypeTires();
            ViewBag.TypeTires = typeTires.GetTypeTires();

            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            ViewBag.Vehicles = vehicles.GetVehicles();

            if (ModelState.IsValid)
            {
                Logica.BL.VehicleGeneralInformation vehicleGeneralInformation = new Logica.BL.VehicleGeneralInformation();
                vehicleGeneralInformation.CreateVehicleGeneralInformation(
                    model.BrandId,
                    model.Line,
                    model.Model,
                    model.Color,
                    model.SerialNumber,
                    model.EngineNumber,
                    model.ChassisNumber,
                    model.VIN,
                    model.Cylinder,
                    model.TypeBody,
                    model.TypeFuelId,
                    model.InitialEnrollmentDate,
                    model.NroDoors,
                    model.TypeTireId,
                    model.AuthoritiesTransitId,
                    model.VehicleId
                    );

                return View("Index");

            }
            return View(model);
        }

    }
}
