using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.BioMolus
{
    public class BioSingleQuery : IRequest<Bio>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        


        // nested class clasin icinde class
        public class BioSingleQueryHandler : IRequestHandler<BioSingleQuery, Bio>
        {
            readonly PortfolioDbContext db;
            public BioSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<Bio> Handle(BioSingleQuery model, CancellationToken cancellationToken)
            {

             
                var bio = await db.Bios
                   .FirstOrDefaultAsync(cancellationToken);

                return bio;
            }
        }



    }
}
