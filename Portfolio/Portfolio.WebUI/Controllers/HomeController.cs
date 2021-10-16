using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Modules.ContactModules.ContactUser;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class HomeController : Controller
    {

        readonly IMediator db;

        public HomeController(IMediator db)
        {
            this.db = db;


        }
        //+
        public IActionResult Index()
        {
            return View();
        }


    
        //+
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //+
        public async Task<IActionResult> Contact(ContactCreateCommand query)
        {

            var respons = await db.Send(query);
            return Json(respons);
        }

    }
}
