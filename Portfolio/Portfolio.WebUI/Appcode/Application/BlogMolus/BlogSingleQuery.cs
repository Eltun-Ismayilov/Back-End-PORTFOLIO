﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Appcode.Application.BlogMolus
{
    public class BlogSingleQuery : IRequest<BlogPost>
    {
        // bu hisse query model adlanir;(axtaris zamani bura lazim olur)
        public int Id { get; set; }


        // nested class clasin icinde class
        public class BlogSingleQueryHandler : IRequestHandler<BlogSingleQuery, BlogPost>
        {
            readonly PortfolioDbContext db;
            public BlogSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            // qeury servic adlanir;    
            public async Task<BlogPost> Handle(BlogSingleQuery model, CancellationToken cancellationToken)
            {

                if (model.Id <= 0)
                {
                    return null;
                }
                var blog = await db.BlogPosts
                   .FirstOrDefaultAsync(m => m.Id == model.Id, cancellationToken);

                return blog;
            }
        }

    }
}
