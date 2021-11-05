using MediatR;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using Portfolio.Domain.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.ProjectMolus
{
    public class ProjectPagedQuery: IRequest<PagedViewModel<Project>>
    {
        public int pageIndex { get; set; } = 1;
        public int pageSize { get; set; } = 3;

        public class ProjectPagedQueryHandler : IRequestHandler<ProjectPagedQuery, PagedViewModel<Project>>
        {
            readonly PortfolioDbContext db;
            public ProjectPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<PagedViewModel<Project>> Handle(ProjectPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.Projects.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<Project>(query, model.pageIndex, model.pageSize);
            }
        }
    
    }
}
