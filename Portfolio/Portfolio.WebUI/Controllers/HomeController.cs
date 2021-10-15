using Microsoft.AspNetCore.Mvc;
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
        readonly PortfolioDbContext db;

        public HomeController(PortfolioDbContext db)
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
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(model);

                db.SaveChanges();

               
                return Json(new
                {
                    // error yoxdusa bura dusur
                    error = false,
                    message = "Sorgunuz qeyde alindir"
                });


            }
            return Json(new
            {

                // error varsa bura dusur
                error = true,
                message = "Mellumatin dogrulugnu yoxluyun"
            });
        }

    }
}
