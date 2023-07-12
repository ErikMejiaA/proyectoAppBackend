using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ConsultorioConfiguration : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("consultorio");

        builder.Property(p => p.Cons_codigo)
        .IsRequired();

        builder.Property(p => p.Cons_nombre)
        .IsRequired()
        .HasMaxLength(50);
        
    }
}
