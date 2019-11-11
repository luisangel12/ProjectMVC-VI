﻿using ProjectMVC.DAL.Models;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class ActivitiesWSController : Controller
    {
        // GET: ActivitiesWS
        public ActionResult Index()
        {
            WSTest.Test test = new WSTest.Test();
            test.Url = ConfigurationManager.AppSettings["WedServiceEndpoint"].ToString();

            var listActivities = (from q in test.GetActivities()
                                  select new Logica.Models.ViewModels.ActivitiesIndexViewModels
                                  {
                                      Id = q.Id,
                                      Name = q.Name,
                                      Active = q.Active
                                  }).ToList();

            return View(listActivities);

        }
        public ActionResult Create(Activities activities)
        {
            if (ModelState.IsValid)
            {
                WSTest.Test test = new WSTest.Test();
                test.CreateActivity(activities.Name);

                return RedirectToAction("Index");
            }

            return View(activities);
        }
        
        // GET: Activities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // GET: Activities/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        [HttpPost]
        public ActionResult Create(Logica.Models.BindingModels.ActivitiesBindingModels models)
        {
            if (ModelState.IsValid)
            {
                WSTest.Test test = new WSTest.Test();
                test.Url = ConfigurationManager.AppSettings["WedServiceEndpoint"].ToString();

                Logica.BL.Utils utils = new Logica.BL.Utils();
                var nameEncode = utils.Base64Decode(models.Name);

                test.CreateActivity(nameEncode); 

                return RedirectToAction("Index");
            }

            return View(models);
        }

        // GET5: Activities/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WSTest.Test test = new WSTest.Test();
            test.Url = ConfigurationManager.AppSettings["WedServiceEndpoint"].ToString();

            var activity = (from q in test.GetActivities()
                            where q.Id == id
                            select new Logica.Models.BindingModels.ActivitiesBindingModels
                            {
                                 Id = q.Id,
                                 Name = q.Name,
                                 Active = q.Active
                            }).ToList();

            return View(activity);
        }

        [HttpPost]
        public ActionResult Edit(Logica.Models.BindingModels.ActivitiesBindingModels model)

        {
            if (ModelState.IsValid)
            {

                WSTest.Test test = new WSTest.Test();
                test.Url = ConfigurationManager.AppSettings["WedServiceEndpoint"].ToString();

                Logica.BL.Utils utils = new Logica.BL.Utils();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        // POST: Activities/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return RedirectToAction("Index");
        }
    }
}