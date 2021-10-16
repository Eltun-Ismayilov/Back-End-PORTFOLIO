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

namespace Portfolio.WebUI.Appcode.Application.BlogMolus
{
    public class BlogPagedQuery : IRequest<PagedViewModel<BlogPost>>
    {
        public int pageIndex { get; set; } = 1;
        public int pageSize { get; set; } = 3;

        public class BlogPagedQueryHandler : IRequestHandler<BlogPagedQuery, PagedViewModel<BlogPost>>
        {
            readonly PortfolioDbContext db;
            public BlogPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<BlogPost>(query, model.pageIndex, model.pageSize);
            }
        }
    }
}
