using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("genero");

        builder.Property(p => p.Gen_id)
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p => p.Gen_nombre)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p => p.Gen_abreviatura)
        .IsRequired()
        .HasMaxLength(20);

        
    }
}
