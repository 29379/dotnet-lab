using lab9.Models;
using System.Collections.Generic;
using System.Linq;


namespace lab9.ArticlesContext
{
    public class MapArticlesContext : IArticlesContext
    {
        Dictionary<int, Article> map = new Dictionary<int, Article>
        {
            {0, new Article(0, "40 złotych", 40.00M, null, Category.Other) }
        };

        public List<Article> GetArticles() { return map.Values.ToList(); }

        public Article GetArticle(int id) { return map.GetValueOrDefault(id); }

        public void AddArticle(Article article)
        {
            int index;
            if (map.Count == 0)
            {
                index = 0;
            }
            else
            {
                index = map.Keys.Max(k => k) + 1;
            }
            article.Id = index;
            map.Add(index, article);
        }

        public void RemoveArticle(int id)
        {
            Article toDelete = map.GetValueOrDefault(id);
            if (toDelete != null)
            {
                map.Remove(toDelete.Id);
            }
        }

        public void UpdateArticle(Article article)
        {
            Article toUpdate = map.GetValueOrDefault(article.Id);
            if (toUpdate != null)
            {
                map[toUpdate.Id] = article;
            }
        }

    }
}
