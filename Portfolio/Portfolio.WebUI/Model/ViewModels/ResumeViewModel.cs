using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.ViewModels
{
    public class ResumeViewModel
    {
        public List<Experience> Experiencess { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
        public Bio Bios { get; set; }
    }
}
