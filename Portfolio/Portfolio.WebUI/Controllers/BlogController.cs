using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.BlogMolus;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class BlogController : Controller
    {

        readonly IMediator db;

        public BlogController(IMediator db)
        {
            this.db = db;


        }
        [AllowAnonymous]

        public async Task<IActionResult> Index(BlogPagedQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }
      

        public async Task<IActionResult> Details(BlogSingleQuery query)
        {

            var respons = await db.Send(query);

            return View(respons);
        }
    }
}
