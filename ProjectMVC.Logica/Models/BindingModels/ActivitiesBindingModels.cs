using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class ActivitiesBindingModels
    {

        [Required(ErrorMessage = "The field Id is requires")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is requires")]
        [Display(Name = "Name") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Active is required")]
        [Display(Name = "Active")]
        public bool? Active { get; set; }


    }

    public class ActivitiesUdateBindingModels
    {
        [Required(ErrorMessage = "The field Id is requires")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is requires")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Active is requires")]
        [Display(Name = "Active")]
        public bool? Active { get; set; }


    }
    public class ActivitiesDeletBindingModels
    {
        [Required(ErrorMessage = "The field Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is requires")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Active is required")]
        [Display(Name = "Active")]
        public bool? Active { get; set; }


    }
} 
