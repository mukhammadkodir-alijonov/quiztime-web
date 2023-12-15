using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces;
using QuizTime.DataAccesss.Repositories.Common;
using QuizTime.Domain.Entities.Admins;

namespace QuizTime.DataAccesss.Repositories
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
