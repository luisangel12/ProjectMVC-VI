using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class Cyties
    {
        public List<Models.DB.City> GetCities()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();
            var listCities = (from _cities in _context.Cities
                              where _cities.Active == true
                              select new Models.DB.City
                              {
                                  Id = _cities.Id,
                                  Name = _cities.Name,
                                  Active = _cities.Active
                              }).ToList();

            return listCities;
        }
    }
}
