using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentDatabaseApp.Data;

namespace Student_Database.Data.Configration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student>builder) 
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(n => n.StudentName).IsRequired();
            builder.Property(n => n.StudentName).HasMaxLength(250);
            builder.Property(n => n.StudentAddress).IsRequired(false).HasMaxLength(500);
            builder.Property(n => n.StudentEmail).IsRequired().HasMaxLength(250);

            builder.HasData(new List<Student>()
            {
                new Student {
                    Id = 1,
                    StudentName = "Roohi",
                    StudentlastName = "Sharma",
                    DOB = new DateTime(2010,12,12),
                    StudentAddress = "India",
                    StudentEmail="roohi.sharma@hotmail.com",
                    StudentPhone = 0587123210,
                },

                 new Student {
                    Id = 2,
                    StudentName = "John",
                    StudentlastName = "Philip",
                    DOB = new DateTime(2008,10,13),
                    StudentAddress = "USA",
                    StudentEmail="john_philip@yahoo.com",
                    StudentPhone = 0187121210,
                 },

                  new Student {
                    Id = 3,
                    StudentName = "Maria",
                    StudentlastName = "Wiliam",
                    DOB = new DateTime(2005,06,25),
                    StudentAddress = "Africa",
                    StudentEmail="Maria@gmail.com",
                    StudentPhone = 0102251110,
                  },

                   new Student {
                    Id = 4,
                    StudentName = "Jeck",
                    StudentlastName = "Gurge",
                    DOB = new DateTime(2007,05,18),
                    StudentAddress = "UK",
                    StudentEmail="jeck@gmail.com",
                    StudentPhone = 0447122274,
                   },

                    new Student {
                    Id = 5,
                    StudentName = "Al Makhtum",
                    StudentlastName = "Haider",
                    DOB = new DateTime(2002,01,30),
                    StudentAddress = "UAE",
                    StudentEmail="Almakhtum@gmail.com",
                    StudentPhone = 0998422274,
                    },
            });

        }

    }
}
