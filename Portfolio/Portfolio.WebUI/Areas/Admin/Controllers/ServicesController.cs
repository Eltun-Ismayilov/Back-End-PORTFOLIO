using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.ServiceMolus;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        readonly IMediator mediator;
        public ServicesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(ServicesPagedQuery query)
        {
            var respons = await mediator.Send(query);
            return View(respons);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServicesCreateCommand command)
        {

            Services model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));




            return View(command);
        }


    }
}
