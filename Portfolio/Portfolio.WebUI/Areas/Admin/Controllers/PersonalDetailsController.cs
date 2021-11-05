using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.PersonalMolus;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PersonalDetailsController : Controller
    {
        private readonly IMediator mediator;

        public PersonalDetailsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(PersonalDetailsPagedQuery request)
        {

           var response = await mediator.Send(request);

            return View(response);
        }


        public async Task<IActionResult> Details(PersonalDetailsSingleQuery query)
        {


            var respons = await mediator.Send(query);
            if (respons == null)
            {
                return NotFound();
            }


            return View(respons);
        }


        public async Task<IActionResult> Edit(PersonalDetailsSingleQuery query)
        {


            var respons = await mediator.Send(query);


            if (respons == null)
            {
                return NotFound();
            }

            PersonalDetailsViewModel vm = new PersonalDetailsViewModel();
            vm.Id = respons.Id;
            vm.Name = respons.Name;
            vm.Location = respons.Location;
            vm.Degree = respons.Degree;
            vm.Location = respons.Location;
            vm.Phone = respons.Phone;
            vm.Email = respons.Email;
            vm.Age = respons.Age;
            vm.Experience = respons.Experience;
            vm.CareerLevel = respons.CareerLevel;
            vm.Fax = respons.Fax;
            vm.Website = respons.Website;
            vm.Occupation = respons.Occupation;
            vm.About = respons.About;
            return View(vm);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Edit(PersonalDetailsEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);
        }


    }
}
