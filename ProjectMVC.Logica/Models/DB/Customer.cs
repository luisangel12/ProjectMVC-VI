﻿using ProjectMVC.DAL.Models;
using ProjectMVC.Logica.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class Customer
    {
        public Customer()
        {
            DocumentTypes = new DocumentTypes();
            City = new City();
        }
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }

        public string DocumentNumber { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Surname { get; set; }

        public string SecondSurname { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }

        public int CityId { get; set; }

        public string UserId { get; set; }



        public DocumentTypes DocumentTypes { get; set; }
        public City City { get; set; }
    }
}
