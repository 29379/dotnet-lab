using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab12;
using lab12.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace lab12.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly lab12.Lab12DbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CreateModel(Lab12DbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Article Article { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string fileName = null;
            if (Article.FormFile != null)
            {
                string folder = Path.Combine(_hostingEnvironment.WebRootPath, "upload");
                fileName = Guid.NewGuid().ToString() + "_" + Article.FormFile.FileName;
                string filePath = Path.Combine(folder, fileName);
                FileStream p = new(filePath, FileMode.Create);
                Article.FormFile.CopyTo(p);
                p.Dispose();
                Article.FilePath = fileName;
            }

            _context.Articles.Add(Article);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
