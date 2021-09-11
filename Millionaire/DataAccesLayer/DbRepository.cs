using DataAccesLayer.Entities;
using System.Linq;

namespace DataAccesLayer
{
    public class DbRepository : IDbRepository
    {
        private readonly DataContext _context;

        public DbRepository(DataContext context)
        {
            _context = context;
        }
        public IQueryable<Question> Get()
        {
            return _context.Questions.AsQueryable();
        }
    }
}
