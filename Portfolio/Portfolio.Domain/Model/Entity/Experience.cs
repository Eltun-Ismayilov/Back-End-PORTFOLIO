using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Domain.Model.Entity
{
    public class Experience:BaseEntity
    {
        [Required]

        public string TimeInterval { get; set; }
        [Required]

        public string WorkName { get; set; }
        [Required]

        public string WorkType { get; set; }
        [Required]

        public string WorkPlace { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Logo { get; set; }
    }
}
