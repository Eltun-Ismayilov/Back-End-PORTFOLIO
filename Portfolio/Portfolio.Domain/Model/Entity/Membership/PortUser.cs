using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Domain.Model.Entity.Membership
{
    public class PortUser:IdentityUser<int>
    {
        public bool Activates { get; set; }

    }
}
