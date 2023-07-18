using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class Tipo_documentoConfiguration : IEntityTypeConfiguration<Tipo_documento>
{
    public void Configure(EntityTypeBuilder<Tipo_documento> builder)
    {
        //definimos las propiedades a los atributos de la entidad
        
        builder.ToTable("tipo_documento");

        builder.Property(p => p.Tipdoc_id)
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p => p.Tipodoc_nombre)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p => p.Tipdoc_abreviatura)
        .IsRequired()
        .HasMaxLength(20);
        


    }
}
