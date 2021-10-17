using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.ProjectMolus;
using Portfolio.WebUI.Model.DataContexts;
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

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(BlogsCreateComman command)
        //{

        //    BlogPost model = await mediator.Send(command);

        //    if (model != null)

        //        return RedirectToAction(nameof(Index));

        //    return View(command);
        //}

    }
}
