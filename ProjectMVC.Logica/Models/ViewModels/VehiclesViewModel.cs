using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.ViewModels
{

    #region VehiclesViewModel
    public class VehiclesViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "LicensePlate")]
        public string LicensePlate { get; set; }

        [Display(Name = "NroTransitLicense")]
        public string NroTransitLicense { get; set; }

        [Display(Name = "StateVehicle")]
        public bool? StateVehicle { get; set; }

        [Display(Name = "TypeServiceId")]
        public int? TypeServiceId { get; set; }

        [Display(Name = "ClassVehicleId")]
        public int? ClassVehicleId { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "CustomerId")]
        public int? CustomerId { get; set; }
    }
    #endregion
}
