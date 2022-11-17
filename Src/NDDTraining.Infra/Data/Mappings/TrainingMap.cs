using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDDTraining.Domain.Models;

namespace NDDTraining.Infra.Data.Mappings;

public class TrainingMap : IEntityTypeConfiguration<Training>
{
    public void Configure(EntityTypeBuilder<Training> entity)
    {
        entity.ToTable("TRAININGS");

        entity.HasKey(t => t.Id);

        entity.Property(t => t.Id)
            .HasColumnName("ID");

        entity.Property(t => t.Url)
            .HasColumnName("URL")
            .HasColumnType("VARCHAR")
            .HasMaxLength(200)
            .IsRequired();

        entity.Property(t => t.Title)
            .HasColumnName("TITLE")
            .HasColumnType("VARCHAR")
            .HasMaxLength(100)
            .IsRequired();

        entity.Property(t => t.Description)
            .HasColumnName("DESCRIPTION")
            .HasColumnType("VARCHAR")
            .HasMaxLength(400)
            .IsRequired();

        entity.Property(t => t.Teacher)
            .HasColumnName("TEACHER")
            .HasColumnType("VARCHAR")
            .HasMaxLength(150)
            .IsRequired();

        entity.Property(t => t.Duration)
            .HasColumnName("DURATION")
            .HasColumnType("INT")
            .IsRequired();

        entity.Property(t => t.Active)
            .HasColumnName("ACTIVE")
            .IsRequired();

        entity.Property(t => t.Category)
            .HasColumnName("CATEGORY")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();
    }
}
