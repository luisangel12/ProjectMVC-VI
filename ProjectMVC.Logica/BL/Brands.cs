using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class Brands
    {
        public List<Models.DB.Brands> GetBrands()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listBrands = (from _brands in _context.Brands
                                          where _brands.Active == true
                                          select new Models.DB.Brands
                                          {
                                              Id = _brands.Id,
                                              Name = _brands.Name,
                                              Active = _brands.Active
                                          }).ToList();

            return listBrands;
        }
    }
}
