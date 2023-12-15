using Microsoft.EntityFrameworkCore;
using QuizTime.Domain.Entities.Admins;
using QuizTime.Domain.Entities.Students;
using QuizTime.Domain.Entities.Teachers;
using QuizTime.Domain.Entities.Tests;

namespace QuizTime.DataAccesss.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        public virtual DbSet<Admin> Admins { get; set; } = default!;
        public virtual DbSet<Teacher> Teachers { get; set; } = default!;
        public virtual DbSet<Student> Students { get; set; } = default!;
        public virtual DbSet<Test> Tests { get; set; } = default!;
        public virtual DbSet<StudentTest> StudentTests { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
