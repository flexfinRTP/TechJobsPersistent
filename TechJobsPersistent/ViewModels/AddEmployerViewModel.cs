using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Job is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Skill is required")]
        public string Location { get; set; }
    }
}
