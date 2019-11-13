using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class TypeDocument
    {
        /// <summary>
        /// GetDocumentType
        /// </summary>
        /// <returns></returns>
        public List<Models.DB.DocumentTypes> GetTypeDocument()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();
            var listTypeDocument = (from _typedocument in _context.DocumentTypes
                              where _typedocument.Active == true
                              select new Models.DB.DocumentTypes
                              {
                                  Id = _typedocument.Id,
                                  Name = _typedocument.Name,
                                  Active = _typedocument.Active
                              }).ToList();

            return listTypeDocument;
        }
    }
}
