using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces;
using QuizTime.DataAccesss.Repositories.Common;
using QuizTime.Domain.Entities.Tests;

namespace QuizTime.DataAccesss.Repositories
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
