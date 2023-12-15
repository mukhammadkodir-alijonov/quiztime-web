using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuizTime.DataAccesss.Interfaces.Common
{
    public interface IUnitOfWork
    {
        public IAdminRepository Admins { get; }
        public ITeacherRepository Teachers { get; }
        public IStudentRepository Students { get; }
        public ITestRepository Tests { get; }
        public IStudentTestRepository StudentTests { get; }
        public Task<int> SaveChangesAsync();
        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
