using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayout.Models;

public partial class CvdataBaseContext : DbContext
{
    public CvdataBaseContext()
    {
    }

    public CvdataBaseContext(DbContextOptions<CvdataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EducationDatum> EducationData { get; set; }

    public virtual DbSet<ExperienceDatum> ExperienceData { get; set; }

    public virtual DbSet<ModalityTraining> ModalityTrainings { get; set; }

    public virtual DbSet<PersonalDatum> PersonalData { get; set; }

    public virtual DbSet<PersonalReference> PersonalReferences { get; set; }

    public virtual DbSet<SummaryDatum> SummaryData { get; set; }

    public virtual DbSet<TypeTraining> TypeTrainings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=CVDataBase;Username=postgres;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EducationDatum>(entity =>
        {
            entity.HasKey(e => e.IdEducationData).HasName("educationData_pkey");

            entity.ToTable("educationData");

            entity.Property(e => e.IdEducationData)
                .HasIdentityOptions(null, null, null, 99999999L, true, null)
                .HasColumnName("id_education_Data");
            entity.Property(e => e.DataEducation)
                .HasColumnType("json")
                .HasColumnName("data_Education");
            entity.Property(e => e.IdModalityTraining).HasColumnName("id_modality_Training");
            entity.Property(e => e.IdTypeTraining).HasColumnName("id_type_Training");

            entity.HasOne(d => d.IdModalityTrainingNavigation).WithMany(p => p.EducationData)
                .HasForeignKey(d => d.IdModalityTraining)
                .HasConstraintName("modality_Training");

            entity.HasOne(d => d.IdTypeTrainingNavigation).WithMany(p => p.EducationData)
                .HasForeignKey(d => d.IdTypeTraining)
                .HasConstraintName("type_Training");
        });

        modelBuilder.Entity<ExperienceDatum>(entity =>
        {
            entity.HasKey(e => e.IdExperienceData).HasName("experienceData_pkey");

            entity.ToTable("experienceData");

            entity.Property(e => e.IdExperienceData)
                .HasIdentityOptions(null, null, null, 99999999L, true, null)
                .HasColumnName("id_experience_Data");
            entity.Property(e => e.DataExperience)
                .HasColumnType("json")
                .HasColumnName("data_Experience");
        });

        modelBuilder.Entity<ModalityTraining>(entity =>
        {
            entity.HasKey(e => e.IdModalityTraning).HasName("modalityTraining_pkey");

            entity.ToTable("modalityTraining");

            entity.Property(e => e.IdModalityTraning)
                .HasIdentityOptions(null, null, null, 99999999L, true, null)
                .HasColumnName("id_modalityTraning");
            entity.Property(e => e.Modality)
                .HasColumnType("character varying")
                .HasColumnName("modality");
        });

        modelBuilder.Entity<PersonalDatum>(entity =>
        {
            entity.HasKey(e => e.IdPersonalData).HasName("PersonalData_pkey");

            entity.ToTable("personalData");

            entity.Property(e => e.IdPersonalData).HasColumnName("id_personal_Data");
            entity.Property(e => e.DataPersonal)
                .HasColumnType("json")
                .HasColumnName("data_Personal");
        });

        modelBuilder.Entity<PersonalReference>(entity =>
        {
            entity.HasKey(e => e.IdPersonalReference).HasName("personalReference_pkey");

            entity.ToTable("personalReference");

            entity.Property(e => e.IdPersonalReference)
                .HasIdentityOptions(null, null, null, 99999999L, true, null)
                .HasColumnName("id_personal_Reference");
            entity.Property(e => e.DataPersonalReference)
                .HasColumnType("json")
                .HasColumnName("data_Personal_Reference");
        });

        modelBuilder.Entity<SummaryDatum>(entity =>
        {
            entity.HasKey(e => e.IdSummaryData).HasName("SummaryData_pkey");

            entity.ToTable("summaryData");

            entity.Property(e => e.IdSummaryData)
                .HasIdentityOptions(null, null, null, 99999999L, true, null)
                .HasColumnName("id_summary_Data");
            entity.Property(e => e.Data)
                .HasColumnType("character varying")
                .HasColumnName("data");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<TypeTraining>(entity =>
        {
            entity.HasKey(e => e.IdTypeTraining).HasName("TypeTraining_pkey");

            entity.ToTable("typeTraining");

            entity.Property(e => e.IdTypeTraining)
                .HasIdentityOptions(null, null, null, 99999999L, true, null)
                .HasColumnName("id_type_Training");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
