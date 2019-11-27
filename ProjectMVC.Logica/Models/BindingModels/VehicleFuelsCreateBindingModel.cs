using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class VehicleFuelsCreateBindingModel
    {
        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "TypeFuelId")]
        public int TypeFuelId { get; set; }

        [Required(ErrorMessage = "The field Details is required")]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "The field Expiration Date is required")]
        [Display(Name = "LiterFuel")]
        public double? LiterFuel { get; set; }

        [Required(ErrorMessage = "The field Is Completed is required")]
        [Display(Name = "Plate")]
        public int? VehicleId { get; set; }
       
    }
}
