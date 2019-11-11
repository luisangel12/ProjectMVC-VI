using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.ViewModels
{
    public class ActivitiesIndexViewModels
    {
        [Display(Name = "Id")]
        public int Id { set; get; }

        [Display(Name = "Name")]
        public string Name { set; get; }

        [Display(Name = "Active")]
        public bool WSActive { set; get; }
        public bool? Active { get; set; }
    }
}
