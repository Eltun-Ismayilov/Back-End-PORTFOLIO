using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.ViewModels;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.IndexMolus
{
    public class IndexList : IRequest<IndexViewModel>
    {
        public class IndexListHandler : IRequestHandler<IndexList, IndexViewModel>
        {
            readonly PortfolioDbContext db;
            public IndexListHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<IndexViewModel> Handle(IndexList model, CancellationToken cancellationToken)
            {
                IndexViewModel vm = new IndexViewModel();

                vm.Iconss = await db.Icons.Where(b => b.DeleteByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.Servicess = await db.Services.Where(b => b.DeleteByUserId == null).Include(i=>i.Icons).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.Skills = await db.Skills.Where(b => b.DeleteByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.PersonalDetailss = await db.PersonalDetailss.FirstOrDefaultAsync(b => b.DeleteByUserId == null); // silinmemisleri getirir

                return vm;

            }
        }

    }
}
