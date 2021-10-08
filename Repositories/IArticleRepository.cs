using System.Linq;
using WebApiMachine.Models;

namespace WebApiMachine.Repositories
{
    public interface IArticleRepository
    {
        IQueryable<Article> Get(string type);
    }
}
