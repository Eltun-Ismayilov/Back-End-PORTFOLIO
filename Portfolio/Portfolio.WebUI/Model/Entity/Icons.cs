using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.Entity
{
    public class Icons:BaseEntity
    {
        public string Icon { get; set; }

        public virtual ICollection<Services> Services { get; set; }


    }
}
