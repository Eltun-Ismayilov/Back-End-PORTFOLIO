using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.DataContexts
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions options)
             : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }


    }
}
