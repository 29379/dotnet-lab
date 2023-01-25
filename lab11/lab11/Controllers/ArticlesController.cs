using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab11.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using lab11;
using lab11.ViewModels;

namespace lab11.Controllers
{
	public class ArticlesController : Controller
	{
		private readonly ShopDbContext _context;
		private readonly IWebHostEnvironment _hostingEnvironment;

		public ArticlesController(ShopDbContext context, IWebHostEnvironment hostingEnvironment)
		{
			_context = context;
			_hostingEnvironment = hostingEnvironment;
		}


		// GET: Articles
		public async Task<IActionResult> Index()
		{
			var shopDb = _context.Articles.Include(a => a.Category);
			return View(await shopDb.ToListAsync());
		}

		// GET: Articles/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var elem = await _context.Articles
				.Include(a => a.Category)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (elem == null)
			{
				return NotFound();
			}

			return View(elem);
		}

		// GET: Articles/Create
		public IActionResult Create()
		{
			ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
			return View();
		}

		// POST: Articles/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Price,CategoryId,FormFile")] ArticleCreateViewModel articleView)
		{
			if (ModelState.IsValid)
			{
				string fileName = null;
				if (articleView.FormFile != null)
				{
					string folder = Path.Combine(_hostingEnvironment.WebRootPath, "upload");
					fileName = Guid.NewGuid().ToString() + "_" + articleView.FormFile.FileName;
					string filePath = Path.Combine(folder, fileName);
                    FileStream p = new(filePath, FileMode.Create);
                    articleView.FormFile.CopyTo(p);
					p.Dispose();
				}

				var article = new Article
				{
					Name = articleView.Name,
					Price = articleView.Price,
					CategoryId = articleView.CategoryId,
					FilePath = fileName
				};

				_context.Add(article);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", articleView.CategoryId);
			return View(articleView);
		}

		// GET: Articles/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var article = await _context.Articles.FindAsync(id);
			if (article == null)
			{
				return NotFound();
			}
			ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
			return View(article);
		}

		// POST: Articles/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,FilePath,CategoryId")] Article article)
		{
			if (id != article.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(article);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException e)
				{
					if (!ArticleExists(article.Id))
					{
						return NotFound();
					}
					else
					{
						throw e;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
			return View(article);
		}

		// GET: Articles/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var article = await _context.Articles
				.Include(a => a.Category)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (article == null)
			{
				return NotFound();
			}

			return View(article);
		}

		// POST: Articles/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{

			var article = await _context.Articles.FindAsync(id);
			if (article.FilePath != null)
			{
				string folder = Path.Combine(_hostingEnvironment.WebRootPath, "upload");
				string filePath = Path.Combine(folder, article.FilePath);
				article.FilePath = null;
				if (System.IO.File.Exists(filePath))
				{
					FileInfo fi = new FileInfo(filePath);
					if (fi != null)
					{
						System.IO.File.Delete(filePath);
						fi.Delete();
					}
				}
			}
			_context.Articles.Remove(article);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ArticleExists(int id)
		{
			return _context.Articles.Any(e => e.Id == id);
		}
	}
}