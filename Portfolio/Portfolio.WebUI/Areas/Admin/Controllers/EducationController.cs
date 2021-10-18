using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.EducationMolus;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class EducationController : Controller
    {
        private readonly IMediator mediator;

        public EducationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index(EducationPagedQuery request)
        {
            var response = await mediator.Send(request);

            return View(response);
        }

        public async Task<IActionResult> Details(EducationSingleQuery query)
        {


            var respons = await mediator.Send(query);
            if (respons == null)
            {
                return NotFound();
            }


            return View(respons);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EducationCreateCommand command)
        {

            Education model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));




            return View(command);
        }






    }
}
