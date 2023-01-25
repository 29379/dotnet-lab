using lab9.Models;
using System.Collections.Generic;

namespace lab9.ArticlesContext
{
    public class ListArticlesContext : IArticlesContext
    {
        List<Article> articlesList = new List<Article>
        {
            new Article(0, "Pięćdziesiąt złotych", 50.0M, null, Category.Other)
        };

        public List<Article> GetArticles() { return articlesList; }

        public Article GetArticle(int id) { 
            if (id >= articlesList.Count || id < 0)
            {
                return null;
            }
            return articlesList[id];
        }

        public void AddArticle(Article article) {
            int index = articlesList.Count;
            article.Id = index;
            articlesList.Add(article);
        }

        public void RemoveArticle(int id) {
            Article toDelete = null;
            if (id < articlesList.Count && id >= 0)
            {
                toDelete = articlesList[id];
            }
            if (toDelete != null)
            {
                articlesList.Remove(toDelete);
            }
        }

        public void UpdateArticle(Article article) {
            int index = articlesList.FindIndex(a => a.Id == article.Id);
            if (index != -1)
            {
                articlesList[index] = article;
            }
        }
    }
}
