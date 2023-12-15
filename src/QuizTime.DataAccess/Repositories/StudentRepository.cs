using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces;
using QuizTime.DataAccesss.Repositories.Common;
using QuizTime.Domain.Entities.Students;

namespace QuizTime.DataAccesss.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
