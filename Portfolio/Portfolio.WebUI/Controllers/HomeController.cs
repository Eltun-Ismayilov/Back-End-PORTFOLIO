using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Modules.ContactModules.ContactUser;
using Portfolio.WebUI.Appcode.Application.IndexMolus;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    [AllowAnonymous]

    public class HomeController : Controller
    {

        readonly IMediator db;

        public HomeController(IMediator db)
        {
            this.db = db;


        }
        //+
        public async Task<IActionResult> Index(IndexList query)
        {
            var respons = await db.Send(query);
            return View(respons);
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

        public IActionResult Signin()
        {
            return View();
        }

    }
}
