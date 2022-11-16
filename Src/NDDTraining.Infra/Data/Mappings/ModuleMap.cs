using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDDTraining.Domain.Models;

namespace NDDTraining.Infra.Data.Mappings;

public class ModuleMap : IEntityTypeConfiguration<Module>
{
    public void Configure(EntityTypeBuilder<Module> entity)
    {
        entity.ToTable("MODULES");

        entity.HasKey(m => m.Id);

        entity.Property(m => m.Id)
            .HasColumnName("ID");

        entity.Property(m => m.TitleModule)
            .HasColumnName("TITLE_MODULE")
            .HasColumnType("VARCHAR")
            .HasMaxLength(100)
            .IsRequired();

        entity.Property(m => m.Link)
            .HasColumnName("LINK")
            .HasColumnType("VARCHAR")
            .HasMaxLength(200)
            .IsRequired();

        entity.Property(m => m.Image)
            .HasColumnName("IMAGE")
            .HasColumnType("VARCHAR")
            .HasMaxLength(200)
            .IsRequired();

        entity.Property(m => m.DescriptionModule)
            .HasColumnName("DESCRIPTION_MODULE")
            .HasColumnType("VARCHAR")
            .HasMaxLength(300)
            .IsRequired();

        entity.Property(m => m.StatusModule)
            .HasColumnName("STATUS_MODULE")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50)
            .IsRequired();
        
        entity.HasOne<Training>(m => m.Training)
            .WithMany(t => t.Modules)
            .HasForeignKey(m => m.TrainingId);
    }
}
