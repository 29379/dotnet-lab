using lab9.ArticlesContext;
using Microsoft.AspNetCore.Mvc;
using lab9.Models;
using Microsoft.AspNetCore.Http;

namespace lab9.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticlesContext _articlesContext;

        public ArticleController(IArticlesContext articlesContext)
        {
            _articlesContext = articlesContext;
        }

        public ActionResult Index()
        {
            return View(_articlesContext.GetArticles());
        }

       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article article)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _articlesContext.AddArticle(article);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Read(int id)
        {
            return View(_articlesContext.GetArticle(id));
        }

        public ActionResult Update(int id)
        {
            return View(_articlesContext.GetArticle(id));
        }

        //  [HttpPut]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Article article)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    article.Id = id;
                    _articlesContext.UpdateArticle(article);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_articlesContext.GetArticle(id));
        }

        //  [HttpDelete]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection form)
        {
            try
            {
                _articlesContext.RemoveArticle(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
