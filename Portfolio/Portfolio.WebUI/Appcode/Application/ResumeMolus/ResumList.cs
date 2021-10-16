using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.ViewModels;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.ResumeMolus
{
    public class ResumList : IRequest<ResumeViewModel>
    {
        public class ResumListHandler : IRequestHandler<ResumList, ResumeViewModel>
        {
            readonly PortfolioDbContext db;
            public ResumListHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<ResumeViewModel> Handle(ResumList model, CancellationToken cancellationToken)
            {
                ResumeViewModel vm = new ResumeViewModel();

                vm.Experiencess = await db.Experiences.Where(b => b.CreateByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.Educations = await db.Educations.Where(b => b.CreateByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.Bios = await db.Bios.FirstOrDefaultAsync(b => b.CreateByUserId == null); // silinmemisleri getirir
                vm.Skills = await db.Skills.Where(b => b.CreateByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir

                return vm;

            }
        }
    }
}
