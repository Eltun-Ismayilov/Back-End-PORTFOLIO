using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.WebUI.Model.DataContexts;
using Portfolio.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactPostController : Controller
    {
        private readonly PortfolioDbContext db;

        public ContactPostController(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index(int typeId)
        {
            var query = db.Contacts.AsQueryable()
                .Where(cp => cp.DeleteByUserId == null);


            ViewBag.query = query.Count();
            ViewBag.Count = query.Where(cp => cp.AnswerByUserId == null).Count();
            ViewBag.Count1 = query.Where(cp => cp.AnswerByUserId != null).Count();

            switch (typeId)
            {
                case 1:
                    query = query.Where(cp => cp.AnswerByUserId == null);
                    break;
                case 2:
                    query = query.Where(cp => cp.AnswerByUserId != null);
                    break;
                default:
                    break;
            }
            return View(await query.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await db.Contacts
                .FirstOrDefaultAsync(m => m.Id == id
                && m.DeleteByUserId == null
                && m.AnswerByUserId == null);

            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }

        [HttpPost]
        public async Task<IActionResult> Answer([Bind("Id", "Answer")] Contact model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            var contactPost = await db.Contacts
                .FirstOrDefaultAsync(m => m.Id == model.Id
                && m.DeleteByUserId == null
                && m.AnswerByUserId == null);

            if (contactPost == null)
            {
                return NotFound();
            }

            contactPost.Answer = model.Answer;
            contactPost.AnswerdData = DateTime.Now;
            contactPost.AnswerByUserId = 1;
            await db.SaveChangesAsync();
            return Redirect(nameof(Index));
        }
    }
}
