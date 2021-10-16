using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.ProjectMolus;
using Portfolio.WebUI.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class ProjectController : Controller
    {

        readonly IMediator db;

        public ProjectController(IMediator db)
        {
            this.db = db;


        }
        public async Task<IActionResult> Index(ProjectPagedQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }
        public async Task<IActionResult> Details(ProjectSingleQuery query)
        {
            var respons = await db.Send(query);

            return View(respons);
        }
    }
}
