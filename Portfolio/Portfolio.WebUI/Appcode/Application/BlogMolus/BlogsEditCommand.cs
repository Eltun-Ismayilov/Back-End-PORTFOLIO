﻿using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Appcode.Extension;
using Portfolio.WebUI.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.BlogMolus
{
    public class BlogsEditCommand: BlogsViewModel, IRequest<int>
    {


        public class BlogsEditCommandHandler : IRequestHandler<BlogsEditCommand, int>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;


            public BlogsEditCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<int> Handle(BlogsEditCommand request, CancellationToken cancellationToken)
            {

                if (request.Id != request.Id)
                {
                    return 0;
                }


                if (string.IsNullOrWhiteSpace(request.ImagePati) && request.file == null)
                {

                    ctx.ActionContext.ModelState.AddModelError("file", "Not Chosen");
                }

                var entity = await db.BlogPosts.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeleteByUserId == null);

                if (entity == null)
                {
                    return 0;
                }

                if (ctx.ModelStateValid())
                {
                    entity.Title = request.Title;
                    entity.BlogType = request.BlogType;
                    entity.ImagePati = request.ImagePati;
                    entity.Description = request.Description;
                    entity.ShopDescription = request.ShopDescription;





                    if (request.file != null)
                    {

                        string extension = Path.GetExtension(request.file.FileName);  //.jpg tapmaq ucundur.

                        request.ImagePati = $"{Guid.NewGuid()}{extension}";//imagenin name 


                        string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", request.ImagePati);

                        using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                        {
                            await request.file.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.ImagePati))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", entity.ImagePati));

                        }
                        entity.ImagePati = request.ImagePati;
                    }

                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;



                }
                return 0;

            }

        }
    }
}
