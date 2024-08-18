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
            modelBuilder.Entity<Course>()
                        .HasOne(x => x.Topic)
                        .WithOne(x => x.Course)
                        .HasForeignKey<Course>(x=>x.Top_Id);

            /*            modelBuilder.Entity<Instructor>()
                                    .HasOne(x => x.Department)
                                    .WithMany(x => x.Instructors)
                                    .HasForeignKey(x => x.Dept_Id)
                                    .OnDelete(DeleteBehavior.NoAction);*/

            modelBuilder.Entity<Department>()
                        .HasOne(x => x.Manager)
                        .WithOne(x => x.ManagedDepartment)
                        .HasForeignKey<Department>(x => x.InsManagerId)
                        .OnDelete(DeleteBehavior.NoAction);




            /*  
             *  
             *  
             *  modelBuilder.Entity<Instructor>(entity =>
                {
                    entity.HasOne(i => i.Department)
                        .WithMany(d => d.Instructors)
                        .HasForeignKey(i => i.Dept_Id)
                        .OnDelete(DeleteBehavior.NoAction);

                    entity.HasOne(i => i.DepartmentManager)
                        .WithOne(d => d.Instructor)
                        .HasForeignKey<Department>(d => d.InsId)
                        .OnDelete(DeleteBehavior.NoAction);
                });*/
            modelBuilder.Entity<Student>()
                        .HasOne(x=>x.Department)
                        .WithMany(x=>x.students)
                        .HasForeignKey(x=>x.Dep_id);




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
