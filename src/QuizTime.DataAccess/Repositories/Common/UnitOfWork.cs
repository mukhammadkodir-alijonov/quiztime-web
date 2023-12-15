using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuizTime.DataAccesss.DbContexts;
using QuizTime.DataAccesss.Interfaces;
using QuizTime.DataAccesss.Interfaces.Common;

namespace QuizTime.DataAccesss.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public IAdminRepository Admins { get; }
        public IStudentRepository Students { get; }
        public ITeacherRepository Teachers { get; }
        public IStudentTestRepository StudentTests { get; }
        public ITestRepository Tests { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.dbContext = appDbContext;

            Admins = new AdminRepository(dbContext);

            Students = new StudentRepository(dbContext);

            Teachers = new TeacherRepository(dbContext);

            Tests = new TestRepository(dbContext);

            StudentTests = new StudentTestRepository(dbContext);
        }

        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            return dbContext.Entry(entity);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
