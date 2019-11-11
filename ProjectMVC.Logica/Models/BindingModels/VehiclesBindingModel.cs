using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class VehiclesCreateBindingModel
    {
        [Required(ErrorMessage = "The field Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field LicensePlate is required")]
        [Display(Name = "LicensePlate")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "The field NroTransitLicense is required")]
        [Display(Name = "NroTransitLicense")]
        public string NroTransitLicense { get; set; }

        [Required(ErrorMessage = "The field StateVehicle is required")]
        [Display(Name = "StateVehicle")]
        public bool StateVehicle { get; set; }


        [Required(ErrorMessage = "The field TypeServiceId is required")]
        [Display(Name = "TypeServiceId")]
        public int TypeServiceId { get; set; }

        [Required(ErrorMessage = "The field ClassVehicleId is required")]
        [Display(Name = "ClassVehicleId")]
        public int ClassVehicleId { get; set; }

        [Required(ErrorMessage = "The field Image is required")]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required(ErrorMessage = "The field CustomerId is required")]
        [Display(Name = "CustomerId")]
        public int CustomerId { get; set; }
    }
}