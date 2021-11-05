using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.ExperinceMolus;
using Portfolio.Domain.Model.Entity;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {

        //private readonly IWebHostEnvironment env;
        private readonly IMediator mediator;

        public ExperienceController(IMediator mediator)
        {
           
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index(ExperiencePagedQuery request)
        {
            var response = await mediator.Send(request);

            return View(response);
        }



        public async Task<IActionResult> Details(ExperienceSingleQuery query)
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
        public async Task<IActionResult> Create(ExperienceCreateComman command)
        {

            Experience model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));

            return View(command);
        }


        public async Task<IActionResult> Edit(ExperienceSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            ExperienceViewModel vm = new ExperienceViewModel();

            vm.Id = respons.Id;
            vm.TimeInterval = respons.TimeInterval;
            vm.WorkName = respons.WorkName;
            vm.WorkType = respons.WorkType;
            vm.WorkPlace = respons.WorkPlace;
            vm.Description = respons.Description;
            vm.Logo = respons.Logo;

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ExperienceEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);



        }


        [HttpPost]

        public async Task<IActionResult> Delete(ExperienceRemoveCommand requst)
        {
            var respons = await mediator.Send(requst);

            return Json(respons);
        }



    }
}
