using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces;
using QuizTime.DataAccesss.Repositories.Common;
using QuizTime.Domain.Entities.Tests;

namespace QuizTime.DataAccesss.Repositories
{
    public class StudentTestRepository : GenericRepository<StudentTest>, IStudentTestRepository
    {
        public StudentTestRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
