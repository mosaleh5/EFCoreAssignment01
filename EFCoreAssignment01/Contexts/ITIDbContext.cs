using EFCoreAssignment01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Contexts
{
    public class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("server = . ; database = ITIDb; trusted_connection = true ;TrustServerCertificate = True; ");
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudCourse>()
                 .HasKey(e => new { e.Stud_Id, e.Course_Id });
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topices { get; set; }
        public DbSet<StudCourse> StudCourse { get; set; }
        public DbSet<CourseInst> CourseInst { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> instructor { get; set; }
        
    }
}
