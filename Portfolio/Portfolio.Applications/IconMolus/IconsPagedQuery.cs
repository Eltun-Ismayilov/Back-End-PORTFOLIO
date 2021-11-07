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

        int pageIndex;
        int pageSize;

        public int PageIndex
        {

            get
            {
                if (pageIndex > 0)
                {
                    return pageIndex;
                }
                return 1;
            }
            set
            {
                if (value > 0)
                {
                    pageIndex = value;
                }
                else
                {
                    pageIndex = 1;
                }
            }
        }


        public int PageSize
        {

            get
            {
                if (pageSize > 0)
                {
                    return pageSize;
                }
                return 15;
            }
            set
            {
                if (value > 0)
                {
                    pageSize = value;
                }
                else
                {
                    pageIndex = 15;
                }
            }
        }

        public class IconsPagedQueryHandler : IRequestHandler<IconsPagedQuery, PagedViewModel<Icons>>
        {
            readonly PortfolioDbContext db;
            public IconsPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<PagedViewModel<Icons>> Handle(IconsPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.Icons.Where(b => b.CreateByUserId == null && b.DeleteData == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<Icons>(query, model.pageIndex=1, model.pageSize=20);
            }
        }

    
    }
}
