using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Application.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.ProjectMolus
{
    public class ProjectCreateComman: IRequest<Project>
    {
        public string ImagePath { get; set; }
        public string CLink { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string Description { get; set; }

        public IFormFile file { get; set; }

        public class ProjectCreateCommanHandler : IRequestHandler<ProjectCreateComman, Project>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public ProjectCreateCommanHandler(PortfolioDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<Project> Handle(ProjectCreateComman model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    Project blog = new Project();
                    string extension = Path.GetExtension(model.file.FileName);  //.jpg tapmaq ucundur. png .gng 

                    blog.ImagePath = $"{Guid.NewGuid()}{extension}";//imagenin name 


                    string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", "portfolio","5", blog.ImagePath);

                    using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await model.file.CopyToAsync(stream);
                    }

                    blog.CLink = model.CLink;
                    blog.ProjectName = model.ProjectName;
                    blog.ProjectType = model.ProjectType;
                    blog.Description = model.Description;
                    db.Add(blog);
                    await db.SaveChangesAsync(cancellationToken);

                    return blog;

                }
                return null;
            }
        }
    
    }
}
