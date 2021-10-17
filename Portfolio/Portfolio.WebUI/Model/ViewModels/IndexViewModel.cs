using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.ViewModels
{
    public class IndexViewModel
    {
        public List<Icons> Iconss { get; set; }
        public List<Services> Servicess { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
