﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Appcode.Application.ExperinceMolus;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.PersonalMolus
{
    public class PersonalDetailsSingleQuery : IRequest<PersonalDetails>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        public int Id { get; set; }


        // nested class clasin icinde class
        public class PersonalDetailsSingleQueryHandler : IRequestHandler<PersonalDetailsSingleQuery, PersonalDetails>
        {
            readonly PortfolioDbContext db;
            public PersonalDetailsSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<PersonalDetails> Handle(PersonalDetailsSingleQuery model, CancellationToken cancellationToken)
            {

                if (model.Id <= 0)
                {
                    return null;
                }
                var blog = await db.PersonalDetailss
                   .FirstOrDefaultAsync(m => m.Id == model.Id, cancellationToken);

                return blog;
            }
        }

    }
}
