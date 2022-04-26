﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20220408213255_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("SmartSchool.API.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PreRequisiteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Workload")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("PreRequisiteId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Name = "Matemática",
                            TeacherId = 1,
                            Workload = 0
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 3,
                            Name = "Matemática",
                            TeacherId = 1,
                            Workload = 0
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Name = "Física",
                            TeacherId = 2,
                            Workload = 0
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1,
                            Name = "Português",
                            TeacherId = 3,
                            Workload = 0
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 1,
                            Name = "Inglês",
                            TeacherId = 4,
                            Workload = 0
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 2,
                            Name = "Inglês",
                            TeacherId = 4,
                            Workload = 0
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 3,
                            Name = "Inglês",
                            TeacherId = 4,
                            Workload = 0
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 1,
                            Name = "Programação",
                            TeacherId = 5,
                            Workload = 0
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 2,
                            Name = "Programação",
                            TeacherId = 5,
                            Workload = 0
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 3,
                            Name = "Programação",
                            TeacherId = 5,
                            Workload = 0
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registration")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marta",
                            PhoneNumber = "33225555",
                            Registration = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 766, DateTimeKind.Local).AddTicks(7944),
                            Surname = "Kent"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Paula",
                            PhoneNumber = "3354058",
                            Registration = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(39),
                            Surname = "Isabela"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Laura",
                            PhoneNumber = "55668899",
                            Registration = 3,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(55),
                            Surname = "Antonia"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Luiza",
                            PhoneNumber = "6565659",
                            Registration = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(63),
                            Surname = "Maria"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lucas",
                            PhoneNumber = "565685415",
                            Registration = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(69),
                            Surname = "Machado"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pedro",
                            PhoneNumber = "456454545",
                            Registration = 6,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(79),
                            Surname = "Alvares"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            BirthDate = new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Paulo",
                            PhoneNumber = "9874512",
                            Registration = 7,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(85),
                            Surname = "José"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("SmartSchool.API.Models.StudentDiscipline", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("StudentsDisciplines");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1308)
                        },
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1980)
                        },
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1986)
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1987)
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1989)
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1993)
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1994)
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1996)
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 3,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(1998)
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2000)
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2002)
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2003)
                        },
                        new
                        {
                            StudentId = 5,
                            DisciplineId = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2005)
                        },
                        new
                        {
                            StudentId = 5,
                            DisciplineId = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2007)
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2008)
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2010)
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 3,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2011)
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2014)
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2016)
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2017)
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 3,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2019)
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2020)
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 767, DateTimeKind.Local).AddTicks(2022)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registration")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Name = "Lauro",
                            Registration = 1,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 756, DateTimeKind.Local).AddTicks(5207),
                            Surname = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Name = "Roberto",
                            Registration = 2,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5696),
                            Surname = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Name = "Ronaldo",
                            Registration = 3,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5712),
                            Surname = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Name = "Rodrigo",
                            Registration = 4,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5715),
                            Surname = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Name = "Alexandre",
                            Registration = 5,
                            StartDate = new DateTime(2022, 4, 8, 18, 32, 54, 757, DateTimeKind.Local).AddTicks(5717),
                            Surname = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Discipline", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Course", "Course")
                        .WithMany("Disciplines")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Discipline", "PreRequisite")
                        .WithMany()
                        .HasForeignKey("PreRequisiteId");

                    b.HasOne("SmartSchool.API.Models.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("PreRequisite");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SmartSchool.API.Models.StudentCourse", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SmartSchool.API.Models.StudentDiscipline", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Discipline", "Discipline")
                        .WithMany("StudentsDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Student", "Student")
                        .WithMany("StudentsDisciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Course", b =>
                {
                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Discipline", b =>
                {
                    b.Navigation("StudentsDisciplines");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Student", b =>
                {
                    b.Navigation("StudentsDisciplines");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Teacher", b =>
                {
                    b.Navigation("Disciplines");
                });
#pragma warning restore 612, 618
        }
    }
}
