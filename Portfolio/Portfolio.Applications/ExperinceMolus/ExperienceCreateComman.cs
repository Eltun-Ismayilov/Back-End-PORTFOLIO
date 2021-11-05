using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Hosting;
using Portfolio.Applications.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.ExperinceMolus
{
    public class ExperienceCreateComman : IRequest<Experience>
    {

        public string TimeInterval { get; set; }


        public string WorkName { get; set; }


        public string WorkType { get; set; }
    

        public string WorkPlace { get; set; }
 

        public string Description { get; set; }


        public string Logo { get; set; }

        public IFormFile file { get; set; }





        public class ExperienceCreateCommanHandler : IRequestHandler<ExperienceCreateComman, Experience>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IHostEnvironment env;
            public ExperienceCreateCommanHandler(PortfolioDbContext db, IActionContextAccessor ctx, IHostEnvironment env) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<Experience> Handle(ExperienceCreateComman model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    Experience blog = new Experience();
                    string extension = Path.GetExtension(model.file.FileName);  //.jpg tapmaq ucundur. png .gng 

                    blog.Logo = $"{Guid.NewGuid()}{extension}";//imagenin name 


                    string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", blog.Logo);

                    using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await model.file.CopyToAsync(stream);
                    }

                    blog.TimeInterval = model.TimeInterval;
                    blog.WorkName = model.WorkName;
                    blog.WorkType = model.WorkType;
                    blog.WorkPlace = model.WorkPlace;
                    blog.Description = model.Description;
                    //blog.Logo = model.Logo;


                    db.Add(blog);
                    await db.SaveChangesAsync(cancellationToken);

                    return blog;

                }
                return null;
            }
        }
    }
}
