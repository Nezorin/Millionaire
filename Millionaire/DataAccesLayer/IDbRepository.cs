using DataAccesLayer.Entities;
using System.Linq;

namespace DataAccesLayer
{
    public interface IDbRepository
    {
        IQueryable<Question> Get();
    }
}
