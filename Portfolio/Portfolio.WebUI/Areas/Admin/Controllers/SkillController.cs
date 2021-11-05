using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.SkillMolus;
using Portfolio.Domain.Model.Entity;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly IMediator mediator;

        public SkillController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(SkillPagedQuery request)
        {
            var response = await mediator.Send(request);

            return View(response);
        }

        public async Task<IActionResult> Details(SkilSingleQuery query)
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
        public async Task<IActionResult> Create(SkilCreateCommand command)
        {

            Skill model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));




            return View(command);
        }



        public async Task<IActionResult> Edit(SkilSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            SkillViewModel vm = new SkillViewModel();

            vm.Id = respons.Id;
            vm.SkillName = respons.SkillName;
            vm.SkillType = respons.SkillType;
            vm.SkillPercentage = respons.SkillPercentage;
            vm.SkillDescription = respons.SkillDescription;
            vm.isHardSkill = respons.isHardSkill;

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SkilEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);



        }


        public async Task<IActionResult> Delete(SkilRemoveCommand requst)
        {

            var respons = await mediator.Send(requst);

            return Json(respons);
        }


    }
}
