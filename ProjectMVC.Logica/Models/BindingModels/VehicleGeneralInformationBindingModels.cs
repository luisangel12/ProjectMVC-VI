using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class VehicleGeneralInformationCreateBindingModel
    {
        //[Required(ErrorMessage = "The field Id is required")]
        //[Display(Name = "Id")]
        //public int Id { get; set; }

        [Required(ErrorMessage = "The field BrandId is required")]
        [Display(Name = "BrandId")]
        public int? BrandId { get; set; }

        [Required(ErrorMessage = "The field Line is required")]
        [Display(Name = "Line")]
        public string Line { get; set; }

        [Required(ErrorMessage = "The field Model is required")]
        [Display(Name = "Model")]
        public int? Model { get; set; }

        [Required(ErrorMessage = "The field Color is required")]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "The field SerialNumber is required")]
        [Display(Name = "SerialNumber")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "The field EngineNumber is required")]
        [Display(Name = "EngineNumber")]
        public string EngineNumber { get; set; }

        [Required(ErrorMessage = "The field ChassisNumber is required")]
        [Display(Name = "ChassisNumber")]
        public string ChassisNumber { get; set; }

        [Required(ErrorMessage = "The field VIN is required")]
        [Display(Name = "VIN")]
        public string VIN { get; set; }

        [Required(ErrorMessage = "The field Cylinder is required")]
        [Display(Name = "Cylinder")]
        public int? Cylinder { get; set; }

        [Required(ErrorMessage = "The field TypeBody is required")]
        [Display(Name = "TypeBody")]
        public string TypeBody { get; set; }

        [Required(ErrorMessage = "The field TypeFuelId is required")]
        [Display(Name = "TypeFuelId")]
        public int? TypeFuelId { get; set; }

        [Required(ErrorMessage = "The field EngineNumber is required")]
        [Display(Name = "EngineNumber")]
        public DateTime? InitialEnrollmentDate { get; set; }

        [Required(ErrorMessage = "The field NroDoors is required")]
        [Display(Name = "NroDoors")]
        public int? NroDoors { get; set; }

        [Required(ErrorMessage = "The field TypeTireId is required")]
        [Display(Name = "TypeTireId")]
        public int? TypeTireId { get; set; }

        [Required(ErrorMessage = "The field AuthoritiesTransitId is required")]
        [Display(Name = "AuthoritiesTransitId")]
        public int? AuthoritiesTransitId { get; set; }

        [Required(ErrorMessage = "The field VehicleId is required")]
        [Display(Name = "VehicleId")]
        public int? VehicleId { get; set; }
    }
}