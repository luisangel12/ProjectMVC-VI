using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class TypeMaintenance
    {
        public List<Models.DB.TypeMaintenance> GetTypeMaintenance()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listTypeMaintenance = (from _typemaintenance in _context.TypeMaintenances
                                   where _typemaintenance.Active == true
                                   select new Models.DB.TypeMaintenance
                                   {
                                       Id = _typemaintenance.Id,
                                       Name = _typemaintenance.Name,
                                       Active = _typemaintenance.Active
                                   }).ToList();

            return listTypeMaintenance;
        }

    }
}
