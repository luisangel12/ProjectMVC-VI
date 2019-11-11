﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class ProjectsCreateBindingModel
    {

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field Details is required")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "The field Expected Completion Date is required")]
        [Display(Name = "Expected Completion Date")]
        public DateTime? ExpectedCompletionDate { get; set; }
    }
}

