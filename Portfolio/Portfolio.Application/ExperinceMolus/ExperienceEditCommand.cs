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

namespace Portfolio.Application.ExperinceMolus
{
    public class ExperienceEditCommand : ExperienceViewModel, IRequest<int>
    {


        public class ExperienceEditCommandHandler : IRequestHandler<ExperienceEditCommand, int>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;


            public ExperienceEditCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<int> Handle(ExperienceEditCommand request, CancellationToken cancellationToken)
            {

                if (request.Id != request.Id)
                {
                    return 0;
                }


                if (string.IsNullOrWhiteSpace(request.Logo) && request.file == null)
                {

                    ctx.ActionContext.ModelState.AddModelError("file", "Not Chosen");
                }

                var entity = await db.Experiences.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeleteByUserId == null);

                if (entity == null)
                {
                    return 0;
                }

                if (ctx.ModelStateValid())
                {
                    entity.TimeInterval = request.TimeInterval;
                    entity.WorkName = request.WorkName;
                    entity.WorkType = request.WorkType;
                    entity.WorkPlace = request.WorkPlace;
                    entity.Description = request.Description;





                    if (request.file != null)
                    {

                        string extension = Path.GetExtension(request.file.FileName);  //.jpg tapmaq ucundur.

                        request.Logo = $"{Guid.NewGuid()}{extension}";//imagenin name 


                        string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", request.Logo);

                        using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                        {
                            await request.file.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.Logo))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", entity.Logo));

                        }
                        entity.Logo = request.Logo;
                    }

                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;



                }
                return 0;

            }

        }
    

    }
}
