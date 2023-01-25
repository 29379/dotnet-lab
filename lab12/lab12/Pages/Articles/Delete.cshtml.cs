using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab12;
using lab12.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace lab12.Pages.Articles
{
    public class DeleteModel : PageModel
    {
        private readonly Lab12DbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public DeleteModel(lab12.Lab12DbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [BindProperty]
        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Articles
                .Include(a => a.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Articles.FindAsync(id);

            if (Article != null)
            {
                if (Article.FilePath != null)
                {
                    string folder = Path.Combine(_hostingEnvironment.WebRootPath, "upload");
                    string filePath = Path.Combine(folder, Article.FilePath);
                    Article.FilePath = null;
                    if (System.IO.File.Exists(filePath))
                    {
                        FileInfo fi = new(filePath);
                        if (fi != null)
                        {
                            System.IO.File.Delete(filePath);
                            fi.Delete();
                        }
                    }
                }
                _context.Articles.Remove(Article);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
