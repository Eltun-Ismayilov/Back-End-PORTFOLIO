using Microsoft.AspNetCore.Mvc;
using Portfolio.WebUI.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class BlogController : Controller
    {

        readonly PortfolioDbContext db;

        public BlogController(PortfolioDbContext db)
        {
            this.db = db;


        }
        public IActionResult Index()
        {

            var data = db.BlogPosts.Where(b => b.DeleteByUserId == null).ToList();

            return View(data);
        }
        public IActionResult Details(int id)
        {
            var data = db.BlogPosts.FirstOrDefault(b => b.DeleteByUserId == null && b.Id == id);

            return View(data);
        }
    }
}
