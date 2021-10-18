using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.SkillMolus
{
    public class SkilSingleQuery : IRequest<Skill>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        public int Id { get; set; }


        // nested class clasin icinde class
        public class SkilSingleQueryHandler : IRequestHandler<SkilSingleQuery, Skill>
        {
            readonly PortfolioDbContext db;
            public SkilSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<Skill> Handle(SkilSingleQuery model, CancellationToken cancellationToken)
            {

                if (model.Id <= 0)
                {
                    return null;
                }
                var brands = await db.Skills
                   .FirstOrDefaultAsync(m => m.Id == model.Id, cancellationToken);

                return brands;
            }
        }


    }
}
