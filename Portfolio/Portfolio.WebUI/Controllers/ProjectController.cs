using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.ProjectMolus;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    [AllowAnonymous]

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
