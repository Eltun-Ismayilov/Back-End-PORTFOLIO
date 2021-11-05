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

namespace Portfolio.Applications.PersonalMolus
{
    public class PersonalDetailsPagedQuery : IRequest<PersonalDetails>
    {
       
        public class PersonalDetailsPagedQueryHandler : IRequestHandler<PersonalDetailsPagedQuery, PersonalDetails>
        {
            readonly PortfolioDbContext db;
            public PersonalDetailsPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<PersonalDetails> Handle(PersonalDetailsPagedQuery model, CancellationToken cancellationToken)
            {
                //var query = await db..Where(b => b.DeleteByUserId == null).ToList(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);
                var response = db.PersonalDetailss.FirstOrDefault(b => b.DeleteData == null);

                return response;
            }
        }

    }
}
