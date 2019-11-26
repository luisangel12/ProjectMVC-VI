using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class VehicleTechnicalDataCreateBindingModel
    {
        [Required(ErrorMessage = "The field Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field CapacityLoad is required")]
        [Display(Name = "CapacityLoad")]
        public bool CapacityLoad { get; set; }

        [Required(ErrorMessage = "The field PassengerCapacity is required")]
        [Display(Name = "PassengerCapacity")]
        public int PassengerCapacity { get; set; }

        [Required(ErrorMessage = "The field GVWR is required")]
        [Display(Name = "GVWR")]
        public bool GVWR { get; set; }

        [Required(ErrorMessage = "The field CapacityPassengersSitting is required")]
        [Display(Name = "CapacityPassengersSitting")]
        public int CapacityPassengersSitting { get; set; }

        [Required(ErrorMessage = "The field NumberAxes is required")]
        [Display(Name = "NumberAxes")]
        public int NumberAxes { get; set; }

        //[Required(ErrorMessage = "The field CustomerId is required")]
        [Display(Name = "VehicleId")]
        public int VehicleId { get; set; }
    }
}