﻿using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.WebUI.Appcode.Extension;
using Portfolio.WebUI.Appcode.Infrastructure;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Application.Modules.ContactModules.ContactUser
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