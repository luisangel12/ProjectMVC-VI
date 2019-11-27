using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class TypeTires
    {
        public List<Models.DB.TypeTires> GetTypeTires()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listTypeTires = (from _typetires in _context.TypeTires
                                 where _typetires.Active == true
                                 select new Models.DB.TypeTires
                                 {
                                     Id = _typetires.Id,
                                     Name = _typetires.Name,
                                     Active = _typetires.Active
                                 }).ToList();

            return listTypeTires;
        }
    }
}
