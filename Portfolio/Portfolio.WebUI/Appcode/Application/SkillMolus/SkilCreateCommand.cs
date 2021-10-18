using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.WebUI.Appcode.Extension;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.SkillMolus
{
    public class SkilCreateCommand: IRequest<Skill>
    {
        public string SkillName { get; set; }
        public string SkillType { get; set; }
        public string SkillPercentage { get; set; }
        public string SkillDescription { get; set; }
        public bool isHardSkill { get; set; }

        public class SkilCreateCommandHandler : IRequestHandler<SkilCreateCommand, Skill>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            public SkilCreateCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<Skill> Handle(SkilCreateCommand model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    Skill brands = new Skill();
                    brands.SkillName = model.SkillName;
                    brands.SkillType = model.SkillType;
                    brands.SkillPercentage = model.SkillPercentage;
                    brands.SkillDescription = model.SkillDescription;
                    brands.isHardSkill = model.isHardSkill;
                    db.Skills.Add(brands);
                    await db.SaveChangesAsync(cancellationToken);

                    return brands;
                }

                return null;

                //ctx.ActionContext.ModelState.IsValid if icinde bu cur yoxlamamaq ucun extension yaziiriq.
            }
        }
    }
}
