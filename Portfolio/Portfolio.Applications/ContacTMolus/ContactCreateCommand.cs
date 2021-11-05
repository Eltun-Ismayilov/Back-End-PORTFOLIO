﻿using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Applications.Appcode.Extension;
using Portfolio.Applications.Appcode.Infrastructure;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.Modules.ContactModules.ContactUser
{
    public class ContactCreateCommand : IRequest<CommandJsonRespons>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public class ContactCreateCommandHandler : IRequestHandler<ContactCreateCommand, CommandJsonRespons>
        {
            readonly PortfolioDbContext db;
            readonly IActionContextAccessor ctx;
            public ContactCreateCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<CommandJsonRespons> Handle(ContactCreateCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonRespons();
                if (ctx.ModelStateValid())
                {
                    var contact = new Contact();
                    contact.Name = request.Name;
                    contact.Email = request.Email;
                    contact.Subject = request.Subject;
                    contact.Content = request.Content;
                    db.Contacts.Add(contact);
                    await db.SaveChangesAsync(cancellationToken);
                    response.Error = false;
                    response.Message = "Successfully";
                    return response;
                }
                response.Error = true;
                response.Message = "Error,Try again";
                return response;
            }
        }

    }
}