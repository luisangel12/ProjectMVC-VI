using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class TypeServices
    {
        /// <summary>
        /// GetDocumentType
        /// </summary>
        /// <returns></returns>
        public List<Models.DB.TypeServices> GetTypeService()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();
            var listTypeService = (from _typeservice in _context.TypeServices
                                    where _typeservice.Active == true
                                    select new Models.DB.TypeServices
                                    {
                                        Id = _typeservice.Id,
                                        Name = _typeservice.Name,
                                        Active = _typeservice.Active
                                    }).ToList();
            return listTypeService;
        }
    }
}
