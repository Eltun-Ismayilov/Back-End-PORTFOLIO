using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Application.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.ServiceMolus
{
    public class ServicesCreateCommand : IRequest<Services>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IconsId { get; set; }
        public virtual Icons Icons { get; set; }


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
                    Services icon = new Services();
                    icon.Title = model.Title;
                    icon.Description = model.Description;
                    icon.IconsId = model.IconsId;

                    db.Services.Add(icon);
                    await db.SaveChangesAsync(cancellationToken);

                    return icon;
                }

                return null;

                //ctx.ActionContext.ModelState.IsValid if icinde bu cur yoxlamamaq ucun extension yaziiriq.
            }
        }
    
    }
}
