using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using Portfolio.WebUI.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.ServiceMolus
{
    public class ServicesPagedQuery : IRequest<PagedViewModel<Services>>
    {
        public int pageIndex { get; set; } = 1;
        public int pageSize { get; set; } = 3;

        public class ServicesPagedQueryHandler : IRequestHandler<ServicesPagedQuery, PagedViewModel<Services>>
        {
            readonly PortfolioDbContext db;
            public ServicesPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<PagedViewModel<Services>> Handle(ServicesPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.Services.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).Include(i=>i.Icons).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<Services>(query, model.pageIndex, model.pageSize);

            }

        }
    }
}

