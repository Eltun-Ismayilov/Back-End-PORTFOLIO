using MediatR;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using Portfolio.WebUI.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.EducationMolus
{
    public class EducationPagedQuery : IRequest<PagedViewModel<Education>>
    {
        public int pageIndex { get; set; } = 1;
        public int pageSize { get; set; } = 3;

        public class BrandPagedQueryHandler : IRequestHandler<EducationPagedQuery, PagedViewModel<Education>>
        {
            readonly PortfolioDbContext db;
            public BrandPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Education>> Handle(EducationPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.Educations.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<Education>(query, model.pageIndex, model.pageSize);
            }
        }
    }
}
