using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab12;
using lab12.Models;

namespace lab12.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly lab12.Lab12DbContext _context;

        public IndexModel(lab12.Lab12DbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Articles
                .Include(c => c.Category).ToListAsync();
        }
    }
}
