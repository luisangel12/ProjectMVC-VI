
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class TypeFuels
    {
        public List<Models.DB.TypeFuels> GetTypeFuels()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listTypeFuels = (from _typefuels in _context.TypeFuels
                              where _typefuels.Active == true
                              select new Models.DB.TypeFuels
                              {
                                  Id = _typefuels.Id,
                                  Name = _typefuels.Name,
                                  Active = _typefuels.Active
                              }).ToList();

            return listTypeFuels;
        }
    }
}
