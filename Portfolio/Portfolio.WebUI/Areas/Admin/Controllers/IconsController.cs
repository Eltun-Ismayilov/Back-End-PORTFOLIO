using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.IconMolus;
using Portfolio.Domain.Model.Entity;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IconsController : Controller
    {
        readonly IMediator mediator;
        public IconsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(IconsPagedQuery query)
        {
            var respons = await mediator.Send(query);
            return View(respons);
        }


        public async Task<IActionResult> Delete(IconsRemoveCommand requst)
        {

            var respons = await mediator.Send(requst);

            return Json(respons);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IconsCreateCommand command)
        {

            Icons model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));




            return View(command);
        }


        public async Task<IActionResult> Edit(IconsSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            IconsViewModel vm = new IconsViewModel();

            vm.Id = respons.Id;
            vm.Icon = respons.Icon;
           

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IconsEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);



        }

    }
}
