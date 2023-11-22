using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebVirus.DBModels;

public partial class StorageContext : DbContext
{
    public StorageContext()
    {
    }

    public StorageContext(DbContextOptions<StorageContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    public virtual DbSet<Coordinator> Coordinators { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Professor> Professors { get; set; }

    public virtual DbSet<ReportMaintenance> ReportMaintenances { get; set; }

    public virtual DbSet<Storer> Storers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<TypeMaintenance> TypeMaintenances { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=storage.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coordinator>(entity =>
        {
            entity.Property(e => e.CoordinatorId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Coordinators).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.Property(e => e.EquipmentId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.Property(e => e.ClusterId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Idorder).ValueGeneratedNever();

            entity.HasOne(d => d.FkProfessorNavigation).WithMany(p => p.Orders).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FkStudentNavigation).WithMany(p => p.Orders).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Professor>(entity =>
        {
            entity.Property(e => e.Payroll).ValueGeneratedNever();

            entity.HasOne(d => d.SubjectFkNavigation).WithMany(p => p.Professors).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.Professors).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ReportMaintenance>(entity =>
        {
            entity.Property(e => e.PkMaintenanceR).ValueGeneratedNever();

            entity.HasOne(d => d.FkEquipmentNavigation).WithMany(p => p.ReportMaintenances).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Storer>(entity =>
        {
            entity.Property(e => e.StorerId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Storers).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Records).ValueGeneratedNever();

            entity.HasOne(d => d.Cluster).WithMany(p => p.Students).OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
