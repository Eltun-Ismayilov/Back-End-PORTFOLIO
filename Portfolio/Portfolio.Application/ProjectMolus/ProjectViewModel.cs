using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Application.ProjectMolus
{
    public class ProjectViewModel
    {
        
        [Required]
        public int? Id { get; set; }
        public string ImagePath { get; set; }
        public string CLink { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string Description { get; set; }
        public IFormFile file { get; set; }

    }
}
