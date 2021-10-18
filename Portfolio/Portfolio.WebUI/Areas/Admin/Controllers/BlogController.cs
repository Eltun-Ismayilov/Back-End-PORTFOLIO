using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Appcode.Application.BlogMolus;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly IMediator mediator;

        public BlogController(IWebHostEnvironment env, IMediator mediator)
        {
            this.env = env;
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(BlogPagedQuery request)
        {
            

            var response = await mediator.Send(request);
            
            return View(response);
        }

        public async Task<IActionResult> Details(BlogSingleQuery query)
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
        public async Task<IActionResult> Create(BlogsCreateComman command)
        {

            BlogPost model = await mediator.Send(command);

            if (model != null)

                return RedirectToAction(nameof(Index));

            return View(command);
        }


        public async Task<IActionResult> Edit(BlogSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            BlogsViewModel vm = new BlogsViewModel();

            vm.Id = respons.Id;
            vm.Title = respons.Title;
            vm.BlogType = respons.BlogType;
            vm.ImagePati = respons.ImagePati;
            vm.Description = respons.Description;
            vm.ShopDescription = respons.ShopDescription;

            return View(vm);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BlogsEditCommand command)
        {

            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);



        }


        [HttpPost]
        public async Task<IActionResult> Delete(BlogsRemoveCommand requst)
        {
            var respons = await mediator.Send(requst);

            return Json(respons);
        }
    }
}
