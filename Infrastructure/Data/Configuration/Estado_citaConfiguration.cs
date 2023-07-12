using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;

public class Estado_citaConfiguration : IEntityTypeConfiguration<Estado_cita>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Estado_cita> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("estado_cita");

        builder.Property(p => p.Estcita_id)
        .IsRequired();

        builder.Property(p => p.Estcita_nombre)
        .IsRequired()
        .HasMaxLength(20);
        
    }
}
