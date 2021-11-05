using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Domain.Model.Entity
{
    public class Services:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IconsId { get; set; }
        public virtual Icons Icons { get; set; }
    }
}
