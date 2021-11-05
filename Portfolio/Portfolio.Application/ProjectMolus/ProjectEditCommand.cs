using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.ProjectMolus
{
    public class ProjectEditCommand: ProjectViewModel, IRequest<int>
    {


        public class ProjectEditCommandHandler : IRequestHandler<ProjectEditCommand, int>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;


            public ProjectEditCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<int> Handle(ProjectEditCommand request, CancellationToken cancellationToken)
            {

                if (request.Id != request.Id)
                {
                    return 0;
                }


                if (string.IsNullOrWhiteSpace(request.ImagePath) && request.file == null)
                {

                    ctx.ActionContext.ModelState.AddModelError("file", "Not Chosen");
                }

                var entity = await db.Projects.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeleteByUserId == null);

                if (entity == null)
                {
                    return 0;
                }

                if (ctx.ModelStateValid())
                {
                    entity.ImagePath = request.ImagePath;
                    entity.CLink = request.CLink;
                    entity.ProjectName = request.ProjectName;
                    entity.ProjectType = request.ProjectType;
                    entity.Description = request.Description;


                    if (request.file != null)
                    {

                        string extension = Path.GetExtension(request.file.FileName);  //.jpg tapmaq ucundur.

                        request.ImagePath = $"{Guid.NewGuid()}{extension}";//imagenin name 


                        string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", "portfolio", "5", request.ImagePath);

                        using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                        {
                            await request.file.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.ImagePath))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", "portfolio", "5", entity.ImagePath));

                        }
                        entity.ImagePath = request.ImagePath;
                    }

                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;



                }
                return 0;

            }

        }
    

    }
}
