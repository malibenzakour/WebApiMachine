using System.Linq;
using WebApiMachine.Context;
using WebApiMachine.Models;

namespace WebApiMachine.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArticleContext _context;

        public ArticleRepository(ArticleContext context)
        {
            _context = context;
        }

        public IQueryable<Article> Get(string type)
        {
            return _context.Articles.Where(x => x.TypeArticle == type);
        }
    }
}