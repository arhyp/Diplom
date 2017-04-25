using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1
{
    public partial class DiplomContext : DbContext
    {
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Enrollee> Enrollee { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<University> University { get; set; }

        // Unable to generate entity type for table 'dbo.Лист1$'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
           
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Desktop\Diplom\Diplom\Diplom.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.IdUniversity).HasColumnName("Id_University");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.IdUniversityNavigation)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.IdUniversity)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Department_University");
            });

            modelBuilder.Entity<Enrollee>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Zno).HasColumnName("ZNO");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.IdEnrollee).HasColumnName("id_Enrollee");

                entity.Property(e => e.IdSpeciality).HasColumnName("id_Speciality");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.HasOne(d => d.IdEnrolleeNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IdEnrollee)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_Enrollee");

                entity.HasOne(d => d.IdSpecialityNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IdSpeciality)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_Speciality");
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.Property(e => e.BudgetCount).HasColumnName("budgetCount");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.IdSpeciality).HasColumnName("Id_Speciality");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.HasOne(d => d.IdSpecialityNavigation)
                    .WithMany(p => p.Rules)
                    .HasForeignKey(d => d.IdSpeciality)
                    .HasConstraintName("FK_Rules_Speciality");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.Property(e => e.IdDepartment).HasColumnName("Id_Department");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.Speciality)
                    .HasForeignKey(d => d.IdDepartment)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Speciality_Department");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.Property(e => e.Name).HasColumnName("name");
            });
        }
    }
}