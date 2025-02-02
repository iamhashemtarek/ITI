using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Models
{
    public class ManagementSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-77H1T1P\\SQLEXPRESS;Database=ManagementSystem;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.DeptId)
                .IsRequired(false);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Trainees)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DeptId)
                .IsRequired(false);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DeptId);

            modelBuilder.Entity<Trainee>()
                .HasMany(t => t.CourseResults)
                .WithOne(c => c.Trainee)
                .HasForeignKey(c => c.TraineeId);


            modelBuilder.Entity<Course>()
                .HasMany(c => c.CourseResults)
                .WithOne(cr => cr.Course)
                .HasForeignKey(cr => cr.CourseId);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.ManagerId);
            

            base.OnModelCreating(modelBuilder);
        }

    }
}
