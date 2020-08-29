using Coding_BootCamp.Entities;
using Coding_BootCamp.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Coding_BootCamp.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<TrainerCourse> TrainerCourses { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectStudent> ProjectStudents { get; set; }

        public ApplicationDbContext() : base("connection", throwIfV1Schema: false)
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().Map(m =>
        //    {
        //        m.MapInheritedProperties();
        //        m.ToTable("Student");
        //    });

        //    modelBuilder.Entity<Trainer>().Map(m =>
        //    {
        //        m.MapInheritedProperties();
        //        m.ToTable("Trainer");
        //    });
        //}

        public static ApplicationDbContext Create() => new ApplicationDbContext();
    }
}
