using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.ViewModels
{
    public class CustomerViewModels
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Tipo de documento")]
        public string DocumentTypeId { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "No. Documento")]
        public string DocumentNumber { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Nombre2")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Apellido")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Apellido 2")]
        public string SecondSurname { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Telefono")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Ciudad")]
        public string CityId { get; set; }

        public string UserId { get; set; }
    }
}
