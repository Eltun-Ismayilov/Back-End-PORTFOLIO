using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Applications.ServiceMolus;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        readonly IMediator mediator;
        readonly PortfolioDbContext db;
        public ServicesController(IMediator mediator, PortfolioDbContext db)
        {
            this.mediator = mediator;
            this.db = db;
        }
        public async Task<IActionResult> Index(ServicesPagedQuery query)
        {
            var respons = await mediator.Send(query);
            return View(respons);
        }


        public async Task<IActionResult> Details(ServicesSingleQuery query)
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
            ViewData["IconsId"] = new SelectList(db.Icons.Where(b => b.DeleteByUserId == null), "Id", "Icon");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServicesCreateCommand command)
        {

            Services model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));



            ViewData["IconsId"] = new SelectList(db.Icons.Where(b => b.DeleteByUserId == null), "Id", "Icon", command.Icons);

            return View(command);
        }


        public async Task<IActionResult> Delete(ServicesRemoveCommand requst)
        {

            var respons = await mediator.Send(requst);

            return Json(respons);
        }



        public async Task<IActionResult> Edit(ServicesSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            ServicesViewModel vm = new ServicesViewModel();

            vm.Id = respons.Id;
            vm.Title = respons.Title;
            vm.Description = respons.Description;
            vm.IconsId = respons.IconsId;

            ViewData["IconsId"] = new SelectList(db.Icons.Where(b => b.DeleteByUserId == null), "Id", "Icon");

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ServicesEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            ViewData["IconsId"] = new SelectList(db.Services, "Id", "Icon", command.IconsId);

            return View(command);



        }



    }
}
