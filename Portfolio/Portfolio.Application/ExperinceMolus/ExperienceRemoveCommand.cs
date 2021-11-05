﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Appcode.Infrastructure;
using Portfolio.Domain.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.ExperinceMolus
{
    public class ExperienceRemoveCommand : IRequest<CommandJsonRespons>
    {

        public int? Id { get; set; }


        public class ExperienceRemoveCommandHandler : IRequestHandler<ExperienceRemoveCommand, CommandJsonRespons>
        {
            readonly PortfolioDbContext db;
            public ExperienceRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonRespons> Handle(ExperienceRemoveCommand request, CancellationToken cancellationToken)
            {

                var response = new CommandJsonRespons();


                if (request.Id == null || request.Id < 1)
                {
                    response.Error = true;
                    response.Message = "Mellumat tamligi qorunmayib";
                    goto end;
                }

                var brand = await db.Experiences.FirstOrDefaultAsync(m => m.Id == request.Id && m.DeleteByUserId == null);

                if (brand == null)
                {
                    response.Error = true;
                    response.Message = "Melumat movcud deyildir.";
                    goto end;
                }

                brand.DeleteByUserId = 1;
                brand.DeleteData = DateTime.Now;
                await db.SaveChangesAsync(cancellationToken);

                response.Error = false;
                response.Message = "ugurlu elemlyat";
                end:
                return response;
            }

        }



    }
}
