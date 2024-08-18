﻿// <auto-generated />
using System;
using EFCoreAssignment01.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAssignment01.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_Id")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.CourseInst", b =>
                {
                    b.Property<int>("InstId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<decimal>("Evaluate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(5,2)")
                        .HasDefaultValue(0m);

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("InstId", "CourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("CourseInst");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("InsManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("InsManagerId")
                        .IsUnique()
                        .HasFilter("[InsManagerId] IS NOT NULL");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Bouns")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(18)
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal")
                        .HasDefaultValue(0m)
                        .HasColumnName("BounsAmount");

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("HoureRate")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9, 2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FullName");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.HasIndex("Id");

                    b.ToTable("instructor");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.StudCourse", b =>
                {
                    b.Property<int>("Stud_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Stud_Id", "Course_Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudCourse");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("Dep_id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dep_id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Topices");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Course", b =>
                {
                    b.HasOne("EFCoreAssignment01.Entities.Topic", "Topic")
                        .WithOne("Course")
                        .HasForeignKey("EFCoreAssignment01.Entities.Course", "Top_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.CourseInst", b =>
                {
                    b.HasOne("EFCoreAssignment01.Entities.Course", null)
                        .WithMany("CourseInsts")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreAssignment01.Entities.Instructor", null)
                        .WithMany("CourseInsts")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Department", b =>
                {
                    b.HasOne("EFCoreAssignment01.Entities.Instructor", "Manager")
                        .WithOne("ManagedDepartment")
                        .HasForeignKey("EFCoreAssignment01.Entities.Department", "InsManagerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Instructor", b =>
                {
                    b.HasOne("EFCoreAssignment01.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.StudCourse", b =>
                {
                    b.HasOne("EFCoreAssignment01.Entities.Course", null)
                        .WithMany("StudCourses")
                        .HasForeignKey("CourseId");

                    b.HasOne("EFCoreAssignment01.Entities.Student", null)
                        .WithMany("StudCourses")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Student", b =>
                {
                    b.HasOne("EFCoreAssignment01.Entities.Department", "Department")
                        .WithMany("students")
                        .HasForeignKey("Dep_id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Course", b =>
                {
                    b.Navigation("CourseInsts");

                    b.Navigation("StudCourses");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("students");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Instructor", b =>
                {
                    b.Navigation("CourseInsts");

                    b.Navigation("ManagedDepartment");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Student", b =>
                {
                    b.Navigation("StudCourses");
                });

            modelBuilder.Entity("EFCoreAssignment01.Entities.Topic", b =>
                {
                    b.Navigation("Course")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
