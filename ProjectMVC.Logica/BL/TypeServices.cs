using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class TypeServices
    {
        /// <summary>
        /// GET TypeServices
        /// </summary>
        /// <returns></returns>
        public List<Models.DB.TypeServices> GetTypeServices()
        {
            DAL.Models.ProjectMVCEntities _context = new DAL.Models.ProjectMVCEntities();
            var listTypeServices = (from _typeServices in _context.TypeServices
                              where _typeServices.Active == true
                              select new Models.DB.TypeServices
                              {
                                  Id = _typeServices.Id,
                                  Name = _typeServices.Name,
                                  Active = _typeServices.Active
                              }).ToList();

            return listTypeServices;
        }
    }
}
