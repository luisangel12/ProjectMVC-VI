using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class VehiclesCreateBindingModel
    {
        

        [Required(ErrorMessage = "The field LicensePlate is required")]
        [Display(Name = "Placa")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "The field NroTransitLicense is required")]
        [Display(Name = "No licencia de transito")]
        public string NroTransitLicense { get; set; }

        [Required(ErrorMessage = "The field StateVehicle is required")]
        [Display(Name = "Estado del vehiculo")]
        public bool StateVehicle { get; set; }


        [Required(ErrorMessage = "The field TypeServiceId is required")]
        [Display(Name = "Tipo de servicio")]
        public int TypeServiceId { get; set; }

        [Required(ErrorMessage = "The field ClassVehicleId is required")]
        [Display(Name = "Clase de vehiculo")]
        public int ClassVehicleId { get; set; }

        [Required(ErrorMessage = "The field Image is required")]
        [Display(Name = "Imagen")]
        public string Image { get; set; }

        //public int? CustomerId { get; set; }
    }
}