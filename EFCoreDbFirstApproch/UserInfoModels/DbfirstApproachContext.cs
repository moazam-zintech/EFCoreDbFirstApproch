using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDbFirstApproch.UserInfoModels;

public partial class DbfirstApproachContext : DbContext
{
    public DbfirstApproachContext()
    {
    }

    public DbfirstApproachContext(DbContextOptions<DbfirstApproachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Info> Infos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=DBFirstApproach;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Info");

            entity.Property(e => e.Designation)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
