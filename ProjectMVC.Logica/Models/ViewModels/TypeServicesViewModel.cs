using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.ViewModels
{

    #region VehiclesViewModel
    public class TypeServicesViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Active")]
        public bool? Active { get; set; }
    }
    #endregion
}