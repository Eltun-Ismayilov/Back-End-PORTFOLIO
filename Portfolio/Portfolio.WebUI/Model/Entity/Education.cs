using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.Entity
{
    public class Education:BaseEntity
    {
        public string TimeInterval { get; set; }
        public string Occoption { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string LinkForDiplom { get; set; }
        public string Description { get; set; }
    }
}
