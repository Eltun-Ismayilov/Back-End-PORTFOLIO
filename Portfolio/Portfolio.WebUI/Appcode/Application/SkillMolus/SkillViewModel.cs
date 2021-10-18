using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.SkillMolus
{
    public class SkillViewModel
    {
        [Required]
        public int? Id { get; set; }
        public string SkillName { get; set; }
        public string SkillType { get; set; }
        public string SkillPercentage { get; set; }
        public string SkillDescription { get; set; }
        public bool isHardSkill { get; set; }
    }
}
