﻿using Portfolio.Application.Appcode.Extension;

namespace Portfolio.Application.BioMolus
{
    public class BioEditCommand : BioViewModel, IRequest<int>
    {


        public class BioEditCommandHandler : IRequestHandler<BioEditCommand, int>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;

            public BioEditCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<int> Handle(BioEditCommand model, CancellationToken cancellationToken)
            {

                if (model.Id == null || model.Id < 0)

                    return 0;




                var entity = await db.Bios.FirstOrDefaultAsync(b => b.Id == model.Id && b.DeleteByUserId == null);

                if (ctx.ModelStateValid())
                {
                    entity.Content = model.Content;
             
                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;
                }


                return 0;
            }
        }
    }
}



