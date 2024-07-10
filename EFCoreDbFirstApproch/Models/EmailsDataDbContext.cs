using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDbFirstApproch.Models;

public partial class EmailsDataDbContext : DbContext
{
    public EmailsDataDbContext()
    {
    }

    public EmailsDataDbContext(DbContextOptions<EmailsDataDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

    public virtual DbSet<Issue> Issues { get; set; }

    public virtual DbSet<StorePro> StorePros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=EmailsDataDB;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmailAddress>(entity =>
        {
            entity.ToTable("emailAddress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Issue>(entity =>
        {
            entity.Property(e => e.Priority).HasColumnName("priority");
        });

        modelBuilder.Entity<StorePro>(entity =>
        {
            entity.ToTable("storePro");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
