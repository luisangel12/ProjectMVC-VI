using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class ClassVehicle
    {
        /// <summary>
        /// GetDocumentType
        /// </summary>
        /// <returns></returns>
        public List<Models.DB.ClassVehicle> GetClassVehicle()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();
            var listTypeService = (from _classvehicle in _context.ClassVehicles
                                   where _classvehicle.Active == true
                                   select new Models.DB.ClassVehicle
                                   {
                                       Id = _classvehicle.Id,
                                       Name = _classvehicle.Name,
                                       Active = _classvehicle.Active
                                   }).ToList();
            return listTypeService;
        }
    }
}
