using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.WebUI.Appcode.Extension;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.ServiceMolus
{
    public class ServicesCreateCommand : IRequest<Services>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public class ServicesCreateCommandHandler : IRequestHandler<ServicesCreateCommand, Services>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            public ServicesCreateCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;

            }
            public async Task<Services> Handle(ServicesCreateCommand model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    Services brands = new Services();
                    brands.Title = model.Title;
                    brands.Description = model.Description;
                   
                    db.Services.Add(brands);
                    await db.SaveChangesAsync(cancellationToken);

                    return brands;
                }

                return null;

                //ctx.ActionContext.ModelState.IsValid if icinde bu cur yoxlamamaq ucun extension yaziiriq.
            }
        }
    
    }
}
