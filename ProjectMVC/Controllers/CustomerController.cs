using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(string UserId)
        {
            Logica.BL.Customer customer = new Logica.BL.Customer();
            var listCustomer = customer.GetCustomer(UserId, null);

            var listCustomerViewModel = listCustomer.Select(x => new Logica.Models.ViewModels.CustomerViewModels
            {
                Id = x.Id,               
                DocumentNumber = x.DocumentNumber,
                FirstName = x.FirstName,
                SecondName = x.SecondName,
                Surname = x.Surname,
                SecondSurname = x.SecondSurname,
                Telephone = x.Telephone,
                DocumentTypeId = x.DocumentTypes.Name,
                CityId = x.City.Name,

            }).ToList();

            return View(listCustomerViewModel);
        }      
    }
}