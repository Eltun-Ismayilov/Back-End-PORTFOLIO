using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.IconMolus
{
    public class IconsSingleQuery : IRequest<Icons>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        public int Id { get; set; }


        // nested class clasin icinde class
        public class IconsSingleQueryHandler : IRequestHandler<IconsSingleQuery, Icons>
        {
            readonly PortfolioDbContext db;
            public IconsSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<Icons> Handle(IconsSingleQuery model, CancellationToken cancellationToken)
            {

                if (model.Id <= 0)
                {
                    return null;
                }
                var blog = await db.Icons
                   .FirstOrDefaultAsync(m => m.Id == model.Id, cancellationToken);

                return blog;
            }
        }
        

    }
}
