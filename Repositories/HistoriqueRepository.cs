using System;
using WebApiMachine.Context;
using WebApiMachine.Models;

namespace WebApiMachine.Repositories
{
    public class HistoriqueRepository : IHistoriqueRepository
    {
        private readonly ArticleContext _context;

        public HistoriqueRepository(ArticleContext context)
        {
            _context = context;
        }

        public bool Post(string id)
        {
            _context.Historiques.Add(new Historique() {
                IdArticle = int.Parse(id),
                DateAchat = DateTime.Now
            });
           _context.SaveChangesAsync();
            return true;
        }

        
    }
}
