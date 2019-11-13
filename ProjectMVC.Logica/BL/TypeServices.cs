using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class TypeServices
    {
        /// <summary>
        /// GET TypeServices
        /// </summary>
        /// <param name="TypeServices"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Models.DB.TypeServices> GetTypeServices()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listTypeServices = (from _TypeServices in _context.TypeServices
                                    //join _states in _context.States on _vehicles.Sta equals _states.Id
                                    //join _activities in _context.Activities on _vehicles.ActivityId equals _activities.Id
                                    //join _priorities in _context.Priorities on _vehicles.PriorityId equals _priorities.Id
                                select new Models.DB.TypeServices
                                {
                                    Id = _TypeServices.Id,
                                    Name = _TypeServices.Name,
                                    Active = _TypeServices.Active,
                                   
                                }).ToList();

            //if (projectId != null)
            //    listTasks = listTasks.Where(x => x.ProjectId == projectId).ToList();
            //if (id != null)
            //    listTasks = listTasks.Where(x => x.Id == id).ToList();

            return listTypeServices;
        }

        /// <summary>
        /// CREATE TypeServices
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="active"></param>
        public void CreateTypeServices(int id,
            string name,
            bool active)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            _context.TypeServices.Add(new DAL.Models.TypeService
            {
                Id = id,
                Name = name,
                Active = active,
                
            });

            _context.SaveChanges();
        }
    }
}
