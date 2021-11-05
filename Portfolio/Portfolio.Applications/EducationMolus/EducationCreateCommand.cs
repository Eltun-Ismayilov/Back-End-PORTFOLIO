using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Applications.Appcode.Extension;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.EducationMolus
{
    public class EducationCreateCommand: IRequest<Education>
    {
        public string TimeInterval { get; set; }
        public string Occoption { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string LinkForDiplom { get; set; }
        public string Description { get; set; }

        public class BrandCreateCommandHandler : IRequestHandler<EducationCreateCommand, Education>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            public BrandCreateCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<Education> Handle(EducationCreateCommand model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    Education brands = new Education();
                    brands.TimeInterval = model.TimeInterval;
                    brands.Occoption = model.Occoption;
                    brands.CompanyName = model.CompanyName;
                    brands.Location = model.Location;
                    brands.LinkForDiplom = model.LinkForDiplom;
                    brands.Description = model.Description;
                    db.Educations.Add(brands);
                    await db.SaveChangesAsync(cancellationToken);

                    return brands;
                }

                return null;

                //ctx.ActionContext.ModelState.IsValid if icinde bu cur yoxlamamaq ucun extension yaziiriq.
            }
        }
    
    }
}
