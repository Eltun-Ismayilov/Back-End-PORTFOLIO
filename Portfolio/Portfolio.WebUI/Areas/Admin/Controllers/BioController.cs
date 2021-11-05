using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.BioMolus;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BioController : Controller
    {
        private readonly IMediator mediator;

        public BioController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Details(BioSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }

            return View(respons);
        }

        public async Task<IActionResult> Edit(BioSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            BioViewModel vm = new BioViewModel();

            vm.Id = respons.Id;
            vm.Content = respons.Content;
         

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BioEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Details));

            return View(command);



        }
    }
}
