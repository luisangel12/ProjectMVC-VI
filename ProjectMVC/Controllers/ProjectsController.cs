using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
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

        public ProjectsController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ProjectsController()
        {

        }
     

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public async Task<ActionResult> Create(Logica.Models.BindingModels.ProjectsCreateBindingModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

        //        Logica.BL.Tenants tenants = new Logica.BL.Tenants();
        //        var tenant = tenants.GetTenants(user.Id).FirstOrDefault();

        //        Logica.BL.Projects projects = new Logica.BL.Projects();
        //        projects.CreateProjects(model.Title,
        //            model.Details,
        //            model.ExpectedCompletionDate,
        //            tenant.Id);

        //        return RedirectToAction("Index");
        //    }

        //    return View(model);
        //}

        public ActionResult Edit(int? id)
        {
            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetProjects(id, null).FirstOrDefault();

            var projectBindingModel = new Logica.Models.BindingModels.ProjectsCreateBindingModel
            {
                Id = project.Id,
                Details = project.Details,
                ExpectedCompletionDate = project.ExpectedCompletionDate,
                Title = project.Title
            };

            return View(projectBindingModel);
        }

        [HttpPost]
        public ActionResult Edit(Logica.Models.BindingModels.ProjectsCreateBindingModel model)
        {
            if (ModelState.IsValid)
            {
                Logica.BL.Projects projects = new Logica.BL.Projects();
                projects.UpdateProjects(model.Id,
                    model.Title,
                    model.Details,
                    model.ExpectedCompletionDate);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Details(int? id)
        {
            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetProjects(id, null).FirstOrDefault();

            var projectDetailsViewModel = new Logica.Models.ViewModels.ProjectsDetailsViewModel
            {
                Details = project.Details,
                ExpectedCompletionDate = project.ExpectedCompletionDate,
                Title = project.Title,
                CreatedAt = project.CreatedAt,
                UpdatedAt = project.UpdatedAt
            };

            return View(projectDetailsViewModel);
        }

        public ActionResult Delete(int? id)
        {
            Logica.BL.Projects projects = new Logica.BL.Projects();
            projects.DeleteProjects(id);

            return RedirectToAction("Index");
        }
    }
}