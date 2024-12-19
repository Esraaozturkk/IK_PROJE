﻿// <auto-generated />
using System;
using IK_PROJE.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IK_PROJE.DataAccess.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CertificateResume", b =>
                {
                    b.Property<int>("certificatesId")
                        .HasColumnType("int");

                    b.Property<int>("resumesId")
                        .HasColumnType("int");

                    b.HasKey("certificatesId", "resumesId");

                    b.HasIndex("resumesId");

                    b.ToTable("CertificateResume");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("AlındığıTarih")
                        .HasColumnType("date");

                    b.Property<string>("Kurum")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.JobPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EmployerId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Açıklama")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KurumAdi")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ReferansAdi")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Yonetici"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "Kullanici"
                        });
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BolumAdı")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MezuniyetTürü")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OkulAdı")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TelNo")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "esra@gmail.com",
                            Name = "Esra",
                            Password = "esra12",
                            RoleId = 2,
                            Surname = "Öztürk",
                            TelNo = "05031234266"
                        });
                });

            modelBuilder.Entity("ProjectResume", b =>
                {
                    b.Property<int>("projectsId")
                        .HasColumnType("int");

                    b.Property<int>("resumesId")
                        .HasColumnType("int");

                    b.HasKey("projectsId", "resumesId");

                    b.HasIndex("resumesId");

                    b.ToTable("ProjectResume");
                });

            modelBuilder.Entity("ReferenceResume", b =>
                {
                    b.Property<int>("referencesId")
                        .HasColumnType("int");

                    b.Property<int>("resumesId")
                        .HasColumnType("int");

                    b.HasKey("referencesId", "resumesId");

                    b.HasIndex("resumesId");

                    b.ToTable("ReferenceResume");
                });

            modelBuilder.Entity("ResumeSchool", b =>
                {
                    b.Property<int>("resumesId")
                        .HasColumnType("int");

                    b.Property<int>("schoolsId")
                        .HasColumnType("int");

                    b.HasKey("resumesId", "schoolsId");

                    b.HasIndex("schoolsId");

                    b.ToTable("ResumeSchool");
                });

            modelBuilder.Entity("ResumeSkills", b =>
                {
                    b.Property<int>("resumesId")
                        .HasColumnType("int");

                    b.Property<int>("skillsId")
                        .HasColumnType("int");

                    b.HasKey("resumesId", "skillsId");

                    b.HasIndex("skillsId");

                    b.ToTable("ResumeSkills");
                });

            modelBuilder.Entity("CertificateResume", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Certificate", null)
                        .WithMany()
                        .HasForeignKey("certificatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Resume", null)
                        .WithMany()
                        .HasForeignKey("resumesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Resume", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.User", "User")
                        .WithMany("resumes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.User", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Role", "roles")
                        .WithMany("users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("roles");
                });

            modelBuilder.Entity("ProjectResume", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Project", null)
                        .WithMany()
                        .HasForeignKey("projectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Resume", null)
                        .WithMany()
                        .HasForeignKey("resumesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReferenceResume", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Reference", null)
                        .WithMany()
                        .HasForeignKey("referencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Resume", null)
                        .WithMany()
                        .HasForeignKey("resumesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeSchool", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Resume", null)
                        .WithMany()
                        .HasForeignKey("resumesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.School", null)
                        .WithMany()
                        .HasForeignKey("schoolsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeSkills", b =>
                {
                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Resume", null)
                        .WithMany()
                        .HasForeignKey("resumesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IK_PROJE.Entity.Entities.Concrete.Skills", null)
                        .WithMany()
                        .HasForeignKey("skillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.Role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("IK_PROJE.Entity.Entities.Concrete.User", b =>
                {
                    b.Navigation("resumes");
                });
#pragma warning restore 612, 618
        }
    }
}