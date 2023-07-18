using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("espesialidad");

        builder.Property(p => p.Esp_id)
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p => p.Esp_nombre)
        .IsRequired()
        .HasMaxLength(20);
        
    }
}
