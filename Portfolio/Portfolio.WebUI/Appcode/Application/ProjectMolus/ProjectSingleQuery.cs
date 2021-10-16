using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.ProjectMolus
{
    public class ProjectSingleQuery : IRequest<Project>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        public int Id { get; set; }


        // nested class clasin icinde class
        public class ProjectSingleQueryHandler : IRequestHandler<ProjectSingleQuery, Project>
        {
            readonly PortfolioDbContext db;
            public ProjectSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<Project> Handle(ProjectSingleQuery model, CancellationToken cancellationToken)
            {

                if (model.Id <= 0)
                {
                    return null;
                }
                var blog = await db.Projects
                   .FirstOrDefaultAsync(m => m.Id == model.Id, cancellationToken);

                return blog;
            }
        }
    
    }
}
