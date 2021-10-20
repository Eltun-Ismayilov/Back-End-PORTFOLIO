using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.Entity;
using Portfolio.WebUI.Model.Entity.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.DataContexts
{
    public class PortfolioDbContext : IdentityDbContext<PortUser,PortRole,int,PortUserClaim,PortUserRole,PortUserLogin,PortRoleClaim,PortUserToken>
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
        public DbSet<PersonalDetails> PersonalDetailss { get; set; }


        // Database olan membershiplerin ADi qabaginda ASP isdemirikse gorsensin ozmuz duz qos eliyib burda yaziriq
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PortUser>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("Users", "Membership");

            });

            builder.Entity<PortRole>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("Roles", "Membership");

            });

            builder.Entity<PortUserRole>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("UserRoles", "Membership");

            });

            builder.Entity<PortUserClaim>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("UserClaims", "Membership");

            });

            builder.Entity<PortRoleClaim>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("RoleClaims", "Membership");

            });
            builder.Entity<PortUserToken>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("UserTokens", "Membership");

            });
            builder.Entity<PortUserLogin>(e => {
                // adi   //ADI qabagindaki
                e.ToTable("UserLogins", "Membership");

            });
        }


    }
}
