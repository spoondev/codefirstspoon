using System.Data.Entity;
using System;
using System.Linq;
using System.Web;

namespace EF6CodeFirstDemo
{
    public class Context : DbContext
    {
        public Context() : base("EF6CodeFirst")
        {
            Database.SetInitializer<Context>(new DBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new StudentConfigurations());

            modelBuilder.Entity<Teacher>()
                .ToTable("TeacherInfo");

            modelBuilder.Entity<Teacher>()
                .MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        //non standard ootb code below this line
        public DbSet<FileInfo> Fileinfos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FileNote> FileNotes { get; set; }
        public DbSet<Action> Actions { get; set; }

    }
}