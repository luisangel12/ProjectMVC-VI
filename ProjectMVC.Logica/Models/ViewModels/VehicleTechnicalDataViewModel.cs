using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.ViewModels
{

    #region VehicleTechnicalDataViewModel
    public class VehicleTechnicalDataViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "CapacityLoad")]
        public bool CapacityLoad { get; set; }

        [Display(Name = "PassengerCapacity")]
        public int PassengerCapacity { get; set; }

        [Display(Name = "GVWR")]
        public bool GVWR { get; set; }

        [Display(Name = "CapacityPassengersSitting")]
        public int? CapacityPassengersSitting { get; set; }

        [Display(Name = "NumberAxes")]
        public int? NumberAxes { get; set; }

        [Display(Name = "VehicleId")]
        public int VehicleId { get; set; }
    }
    #endregion
}
