using MediatR;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using Portfolio.Domain.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.SkillMolus
{
    public class SkillPagedQuery : IRequest<PagedViewModel<Skill>>
    {
        public int pageIndex { get; set; } = 1;
        public int pageSize { get; set; } = 3;

        public class SkillPagedQueryHandler : IRequestHandler<SkillPagedQuery, PagedViewModel<Skill>>
        {
            readonly PortfolioDbContext db;
            public SkillPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Skill>> Handle(SkillPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.Skills.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<Skill>(query, model.pageIndex, model.pageSize);
            }
        }

    }
}
