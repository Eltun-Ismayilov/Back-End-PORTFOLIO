using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.EducationMolus;
using Portfolio.Domain.Model.Entity;
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


        public async Task<IActionResult> Edit(EducationSingleQuery query)
        {


            var respons = await mediator.Send(query);


            if (respons == null)
            {
                return NotFound();
            }

            EducationViewModel vm = new EducationViewModel();
            vm.Id = respons.Id;
            vm.TimeInterval = respons.TimeInterval;
            vm.Occoption = respons.Occoption;
            vm.CompanyName = respons.CompanyName;
            vm.Location = respons.Location;
            vm.LinkForDiplom = respons.LinkForDiplom;
            vm.Description = respons.Description;
            return View(vm);

        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
     

        public async Task<IActionResult> Edit(EducationEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EducationRemoveCommand requst)
        {

            var respons = await mediator.Send(requst);

            return Json(respons);
        }






    }
}
