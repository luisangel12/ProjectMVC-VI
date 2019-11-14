using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class Customer
    {
        public List<Models.DB.Customer> GetCustomer(string UserId,
          int? id)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listCostumer = (from _customer in _context.Customers
                             join _typedocument in _context.DocumentTypes on _customer.DocumentTypeId equals _typedocument.Id
                             join _city in _context.Cities on _customer.CityId equals _city.Id

                             select new Models.DB.Customer
                             {
                                 Id = _customer.Id,
                                 DocumentNumber = _customer.DocumentNumber,
                                 FirstName = _customer.FirstName,
                                 SecondName = _customer.SecondName,
                                 Surname = _customer.Surname,
                                 SecondSurname = _customer.SecondSurname,
                                 Telephone = _customer.Telephone,
                                 Address = _customer.Address,

                                 DocumentTypeId = _customer.Id,
                                 DocumentTypes = new Models.DB.DocumentTypes
                                 {
                                     Name = _typedocument.Name
                                 },

                                 CityId = _customer.Id,
                                 City = new Models.DB.City
                                 {
                                     Name = _city.Name
                                 },
                                 UserId = _customer.UserId
                                
                             }).ToList();

            if (UserId != null)
                listCostumer = listCostumer.Where(x => x.UserId == UserId).ToList();
            if (id != null)
                listCostumer = listCostumer.Where(x => x.Id == id).ToList();

            return listCostumer;
        }
    }
}
