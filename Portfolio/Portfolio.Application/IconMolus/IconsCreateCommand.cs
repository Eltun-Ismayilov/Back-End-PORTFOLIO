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

namespace Portfolio.Application.IconMolus
{
    public class IconsCreateCommand : IRequest<Icons>
    {
        public string Icon { get; set; }
        public int ServiceId { get; set; }


        public class IconsCreateCommandHandler : IRequestHandler<IconsCreateCommand, Icons>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            public IconsCreateCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<Icons> Handle(IconsCreateCommand model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    Icons icon = new Icons();
                    icon.Icon = model.Icon;

                    db.Icons.Add(icon);
                    await db.SaveChangesAsync(cancellationToken);

                    return icon;
                }

                return null;

                //ctx.ActionContext.ModelState.IsValid if icinde bu cur yoxlamamaq ucun extension yaziiriq.
            }
        }


    }
}
