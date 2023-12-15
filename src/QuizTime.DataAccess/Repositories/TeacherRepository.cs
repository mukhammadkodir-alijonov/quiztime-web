using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces;
using QuizTime.DataAccesss.Repositories.Common;
using QuizTime.Domain.Entities.Teachers;

namespace QuizTime.DataAccesss.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
