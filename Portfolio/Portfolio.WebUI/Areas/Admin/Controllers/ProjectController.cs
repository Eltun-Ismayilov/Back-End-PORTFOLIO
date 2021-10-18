using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.ProjectMolus;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProjectController : Controller
    {
        private readonly PortfolioDbContext db;
        private readonly IWebHostEnvironment env;
        private readonly IMediator mediator;

        public ProjectController(PortfolioDbContext db, IWebHostEnvironment env, IMediator mediator)
        {
            this.db = db;
            this.env = env;
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(ProjectPagedQuery query)
        {

            var response = await mediator.Send(query);

            return View(response);
        }

        public async Task<IActionResult> Details(ProjectSingleQuery query)
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
        public async Task<IActionResult> Create(ProjectCreateComman command)
        {

            Project model = await mediator.Send(command);

            if (model != null)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        public async Task<IActionResult> Edit(ProjectSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            ProjectViewModel vm = new ProjectViewModel();

            vm.Id = respons.Id;
            vm.ImagePath = respons.ImagePath;
            vm.CLink = respons.CLink;
            vm.ProjectName = respons.ProjectName;
            vm.ProjectType = respons.ProjectType;
            vm.Description = respons.Description;

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProjectEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);



        }


        public async Task<IActionResult> Delete(ProjectRemoveCommand requst)
        {
            var respons = await mediator.Send(requst);

            return Json(respons);
        }


    }
}
