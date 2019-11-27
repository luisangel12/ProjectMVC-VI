using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class AuthoritiesTransit
    {
        public List<Models.DB.AuthoritiesTransit> GetAuthoritiesTransit()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listAuthoritiesTransit = (from _authoritiestransit in _context.AuthoritiesTransits
                              where _authoritiestransit.Active == true
                              select new Models.DB.AuthoritiesTransit
                              {
                                  Id = _authoritiestransit.Id,
                                  Name = _authoritiestransit.Name,
                                  Active = _authoritiestransit.Active
                              }).ToList();

            return listAuthoritiesTransit;
        }
    }
}
