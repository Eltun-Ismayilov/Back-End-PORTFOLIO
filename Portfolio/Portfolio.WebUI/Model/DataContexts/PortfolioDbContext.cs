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
        public DbSet<Project> Projects { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Icons> Icons { get; set; }
        public DbSet<Services> Services { get; set; }



    }
}
