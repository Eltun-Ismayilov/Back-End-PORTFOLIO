using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Applications.ExperinceMolus
{
    public class ExperienceViewModel
    {
        public int? Id { get; set; }


        public string TimeInterval { get; set; }

        public string WorkName { get; set; }


        public string WorkType { get; set; }


        public string WorkPlace { get; set; }
  
        public string Description { get; set; }
   
        public string Logo { get; set; }

        public IFormFile file { get; set; }

    }
}
