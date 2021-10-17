﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.IndexMolus
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

                vm.Iconss = await db.Icons.Where(b => b.CreateByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.Servicess = await db.Services.Where(b => b.CreateByUserId == null).Include(i=>i.Icons).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.Skills = await db.Skills.Where(b => b.CreateByUserId == null).ToListAsync(cancellationToken); // silinmemisleri getirir
                vm.PersonalDetailss = await db.PersonalDetailss.FirstOrDefaultAsync(b => b.DeleteByUserId == null); // silinmemisleri getirir

                return vm;

            }
        }

    }
}
