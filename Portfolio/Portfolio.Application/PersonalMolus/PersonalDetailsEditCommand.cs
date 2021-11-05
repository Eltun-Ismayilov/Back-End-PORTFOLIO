using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.PersonalMolus
{
    public class PersonalDetailsEditCommand : PersonalDetailsViewModel, IRequest<int>
    {


        public class PersonalDetailsEditCommandHandler : IRequestHandler<PersonalDetailsEditCommand, int>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;

            public PersonalDetailsEditCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<int> Handle(PersonalDetailsEditCommand model, CancellationToken cancellationToken)
            {

                if (model.Id == null || model.Id < 0)

                    return 0;




                var entity = await db.PersonalDetailss.FirstOrDefaultAsync(b => b.Id == model.Id && b.DeleteByUserId == null);

                if (ctx.ModelStateValid())
                {
                    entity.Name = model.Name;
                    entity.Location = model.Location;
                    entity.Degree = model.Degree;
                    entity.Location = model.Location;
                    entity.Phone = model.Phone;
                    entity.Email = model.Email;
                    entity.Age = model.Age;
                    entity.Experience = model.Experience;
                    entity.CareerLevel = model.CareerLevel;
                    entity.Fax = model.Fax;
                    entity.Website = model.Website;
                    entity.Occupation = model.Occupation;
                    entity.About = model.About;
                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;
                }


                return 0;
            }
        }
    }


}








