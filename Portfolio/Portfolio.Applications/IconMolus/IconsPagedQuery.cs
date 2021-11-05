using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using Portfolio.Domain.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.IconMolus
{
    public class IconsPagedQuery : IRequest<PagedViewModel<Icons>>
    {
        public int pageIndex { get; set; } = 1;
        public int pageSize { get; set; } = 3;

        public class IconsPagedQueryHandler : IRequestHandler<IconsPagedQuery, PagedViewModel<Icons>>
        {
            readonly PortfolioDbContext db;
            public IconsPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<PagedViewModel<Icons>> Handle(IconsPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.Icons.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<Icons>(query, model.pageIndex, model.pageSize);
            }
        }

    
    }
}
