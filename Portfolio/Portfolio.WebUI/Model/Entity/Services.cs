using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.Entity
{
    public class Services:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Icons> Icons { get; set; }
    }
}
