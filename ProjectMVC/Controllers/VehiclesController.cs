using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{

    public class VehiclesController : Controller
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

        public VehiclesController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public VehiclesController()
        {

        }

        public ActionResult Index()
        {
            Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
            var listVehicle = vehicles.GetVehicles();

            var listCustomerViewModel = listVehicle.Select(x => new Logica.Models.ViewModels.VehiclesViewModel
            {
                
                LicensePlate = x.LicensePlate,
                NroTransitLicense = x.NroTransitLicense,
                StateVehicle = x.StateVehicle,
                TypeServiceId = x.TypeServiceId,
                ClassVehicleId = x.CustomerId,
                Image = x.Image,
                CustomerId = x.CustomerId

            }).ToList();

            return View(listCustomerViewModel);
        }



        public ActionResult Create()
        {
            Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            ViewBag.TypeService = typeServices.GetTypeServices();

            Logica.BL.ClassVehicle classVehicle = new Logica.BL.ClassVehicle();
            ViewBag.ClassVehicle = classVehicle.GetClassVehicle();

            return View();

        }

        [HttpPost]
        public async Task<ActionResult> Create(Logica.Models.BindingModels.VehiclesCreateBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            Logica.BL.TypeServices typeServices = new Logica.BL.TypeServices();
            ViewBag.TypeService = typeServices.GetTypeServices();

            Logica.BL.ClassVehicle classVehicle = new Logica.BL.ClassVehicle();
            ViewBag.ClassVehicle = classVehicle.GetClassVehicle();

            if (ModelState.IsValid)
            {

                var ImageVehicle = string.Empty;

                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase file = Request.Files[i];

                    string mimeType = file.ContentType;

                    var Image = Guid.NewGuid();
                    var ext = mimeType.Split('/').LastOrDefault();
                    ImageVehicle = string.Format("{0}.{1}", Image, ext);


                    file.SaveAs(Server.MapPath("~/Images/Vehicles/") +
                    string.Format("{0}.{1}", Image, ext));

                }


                Logica.BL.Customer customer = new Logica.BL.Customer();


                var capturaCustomer = customer.GetCustomer(user.Id,null).FirstOrDefault();

                Logica.BL.Vehicles vehicles = new Logica.BL.Vehicles();
                vehicles.CreateVehicles(model.Id,
                    model.LicensePlate,
                    model.NroTransitLicense,
                    model.StateVehicle,
                    model.TypeServiceId,
                    model.ClassVehicleId,
                    ImageVehicle,
                    //model.CustomerId
                    capturaCustomer.Id
                    );

                return View("Create");

            }
            return View(model);
        }

    }
}
