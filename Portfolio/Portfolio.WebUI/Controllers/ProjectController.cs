using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class ProjectController : Controller
    {
        readonly PortfolioDbContext db;

        public ProjectController(PortfolioDbContext db)
        {
            this.db = db;


        }
        public IActionResult Index(int page = 1)
        {

            var productcount = 3;
            ViewBag.PagesCaunt = decimal.Ceiling((decimal)db.Projects.Where(d => d.DeleteByUserId == null).Count() / productcount);
            ViewBag.Page = page;    // 1

            var data= db.Projects.Where(b => b.DeleteByUserId == null).ToList();


            return View(data);
        }
        public IActionResult Details(int id)
        {
            var data = db.Projects.FirstOrDefault(b => b.DeleteByUserId == null && b.Id == id);

            return View(data);
        }
    }
}
