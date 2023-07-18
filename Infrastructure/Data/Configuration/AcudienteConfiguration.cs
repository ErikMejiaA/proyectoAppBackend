using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
{
    public void Configure(EntityTypeBuilder<Acudiente> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("acudiente");

        builder.Property(p => p.Acu_codigo)
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p => p.Acu_nombreCompleto)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Acu_telefono)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Acu_direccion)
        .IsRequired()
        .HasMaxLength(200);

        
    }
}
