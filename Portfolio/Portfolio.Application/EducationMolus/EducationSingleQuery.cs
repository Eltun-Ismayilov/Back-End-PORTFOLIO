using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.EducationMolus
{
    public class EducationSingleQuery : IRequest<Education>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        public int Id { get; set; }


        // nested class clasin icinde class
        public class BrandSingleQueryHandler : IRequestHandler<EducationSingleQuery, Education>
        {
            readonly PortfolioDbContext db;
            public BrandSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<Education> Handle(EducationSingleQuery model, CancellationToken cancellationToken)
            {

                if (model.Id <= 0)
                {
                    return null;
                }
                var brands = await db.Educations
                   .FirstOrDefaultAsync(m => m.Id == model.Id, cancellationToken);

                return brands;
            }
        }
    
    }
}
