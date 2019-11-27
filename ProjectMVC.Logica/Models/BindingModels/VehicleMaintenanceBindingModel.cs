using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class VehicleMaintenanceCreateBindingModel
    {
        [Required(ErrorMessage = "The field Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field MaintenanceDate is required")]
        [Display(Name = "MaintenanceDate")]
        public DateTime? MaintenanceDate { get; set; }

        [Required(ErrorMessage = "The field CurrentMileage is required")]
        [Display(Name = "CurrentMileage")]
        public double? CurrentMileage { get; set; }
        
        [Required(ErrorMessage = "The field NextMaintenanceDate is required")]
        [Display(Name = "NextMaintenanceDate")]
        public DateTime? NextMaintenanceDate { get; set; }

        [Required(ErrorMessage = "The field TypeMaintenanceId is required")]
        [Display(Name = "TypeMaintenanceId")]
        public int? TypeMaintenanceId { get; set; }

        [Required(ErrorMessage = "The field Amount is required")]
        [Display(Name = "Amount")]
        public double? Amount { get; set; }

        [Required(ErrorMessage = "The field VehicleId is required")]
        [Display(Name = "VehicleId")]
        public int? VehicleId { get; set; }

    }
}
