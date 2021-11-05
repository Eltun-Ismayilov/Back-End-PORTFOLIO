using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.Applications.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.IconMolus
{
    public class IconsEditCommand : IconsViewModel, IRequest<int>
    {


        public class EducationEditCommandHandler : IRequestHandler<IconsEditCommand, int>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;

            public EducationEditCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<int> Handle(IconsEditCommand
                model, CancellationToken cancellationToken)
            {

                if (model.Id == null || model.Id < 0)

                    return 0;




                var entity = await db.Icons.FirstOrDefaultAsync(b => b.Id == model.Id && b.DeleteByUserId == null);

                if (ctx.ModelStateValid())
                {
                    entity.Icon = model.Icon;
                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;
                }


                return 0;
            }
        }
    }


}
