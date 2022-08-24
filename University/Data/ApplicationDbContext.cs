using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace University.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<DepartmentLesson>().HasKey(q => new
        //    {
        //        q.LessonId,
        //        q.DepartmentId
        //    });

        //    modelBuilder.Entity<DepartmentLesson>().HasOne(q => q.Lesson).WithMany(t => t.DepartmentLessons).HasForeignKey(t => t.LessonId);
        //    modelBuilder.Entity<DepartmentLesson>().HasOne(q => q.Department).WithMany(t => t.DepartmentLessons).HasForeignKey(t => t.DepartmentId);
        //}
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentLesson> DepartmentLessons { get; set; }
    }
}