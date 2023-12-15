using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces.Common;
using QuizTime.Domain.Common;
using System.Linq.Expressions;

namespace QuizTime.DataAccesss.Repositories.Common
{
    public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T>
    where T : BaseEntity
    {
        public GenericRepository(AppDbContext appDbContext)
        : base(appDbContext)
        {

        }
        public IQueryable<T> GetAll() => _dbSet;

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate) => _dbSet.Where(predicate);
    }
}
