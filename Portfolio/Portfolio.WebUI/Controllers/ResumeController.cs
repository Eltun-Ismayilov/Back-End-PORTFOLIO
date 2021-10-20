using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.ResumeMolus;
using Portfolio.WebUI.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    [AllowAnonymous]

    public class ResumeController : Controller
    {
        readonly IMediator db;

        public ResumeController(IMediator db)
        {
            this.db = db;


        }
        public async Task<IActionResult> Index(ResumList query)
        {
            var respons = await db.Send(query);
            return View(respons);
        }
    }
}
