using Microsoft.EntityFrameworkCore;
using Student_Database.Data.Configration;

namespace StudentDatabaseApp.Data
{
    public class StudentDBContext : DbContext
    {

        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }

        DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Table 1
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }

    }
}
