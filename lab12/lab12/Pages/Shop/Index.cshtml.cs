using lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace lab12.Pages.Shop
{
    public class IndexModel : PageModel
    {
        private readonly lab12.Lab12DbContext _context;

        public IndexModel(lab12.Lab12DbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (Id == null)
            {
                Article = await _context.Articles
                    .Include(a => a.Category)
                    .ToListAsync();
                ViewData["Categories"] = await _context.Categories
                    .ToListAsync();
                ViewData["Current"] = null;
                return Page();
            }
            else
            {
                Category = await _context.Categories
                    .FirstOrDefaultAsync(m => m.Id == Id);
                Article = await _context.Articles
                    .Include(a => a.Category)
                    .Where(a => a.CategoryId == Category.Id)
                    .ToListAsync();

                ViewData["Categories"] = _context.Categories.ToList();
                ViewData["Current"] = Id;

                return Page();
            }
        }
    }
}