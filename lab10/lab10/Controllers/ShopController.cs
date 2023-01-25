using lab10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using lab10;

namespace Lab10.Controllers
{
    public class ShopController : Controller
    {

        private readonly ShopDbContext _context;

        public ShopController(ShopDbContext context)
        {
            _context = context;
        }


        // GET: Articles
        public IActionResult Index()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult IndexList([Bind("Id")] Category myCategory)
        {
            var myDbContext = _context.Articles
                .Include(a => a.Category)
                .Where(a => a.CategoryId == myCategory.Id);

            ViewData["myCategory"] = myCategory.Id;
            return View(myDbContext);
        }
    }
}