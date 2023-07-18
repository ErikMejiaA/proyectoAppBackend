using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Estado_citaConfiguration : IEntityTypeConfiguration<Estado_cita>
{
    public void Configure(EntityTypeBuilder<Estado_cita> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("estado_cita");

        builder.Property(p => p.Estcita_id)
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p => p.Estcita_nombre)
        .IsRequired()
        .HasMaxLength(20);
        
    }
}
