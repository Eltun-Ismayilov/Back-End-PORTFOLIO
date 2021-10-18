using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.BioMolus
{
    public class BioViewModel
    {
        [Required]
        public int? Id { get; set; }
        public string Content { get; set; }

    }
}
