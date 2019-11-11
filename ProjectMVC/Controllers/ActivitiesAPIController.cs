using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class ActivitiesAPIController : Controller
    {
        // GET: Activities
        public async Task<ActionResult> Index()
        {
            HttpContent content =
                new StringContent(JsonConvert.SerializeObject(string.Empty),
                Encoding.UTF8,
                "application/json");

            Logica.Services.RestClient restClient = new Logica.Services.RestClient();
            var result = await restClient.RequestAPI<List<Logica.Models.DB.Activities>>("http://localhost/ProjectMVC.API",
                "/api/Activities/GetActivities",
                content,
                Logica.Services.RestClient.Method.Get);

            var listActivities = new List<Logica.Models.ViewModels.ActivitiesIndexViewModel>();

            if (result.IsSuccess)
            {
                listActivities = (from q in (List<Logica.Models.DB.Activities>)result.Result
                                  select new Logica.Models.ViewModels.ActivitiesIndexViewModel
                                  {
                                      Id = q.Id,
                                      Name = q.Name,
                                      Active = q.Active
                                  }).ToList();
            }

            return View(listActivities);
        }
    }
}