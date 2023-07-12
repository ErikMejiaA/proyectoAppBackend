using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CitasConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("cita");

        builder.Property(p => p.Cit_codigo)
        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired();

        builder.Property(p => p.Cit_fecha)
        .IsRequired()
        .HasColumnType("datetime");

        //definimos las llaves FOREIGN KEY

        builder.HasOne(p => p.Usuario)
        .WithMany(p => p.Citas)
        .HasForeignKey(p => p.Cit_datoUsuario)
        .IsRequired();

        builder.HasOne(p => p.Estado_Cita)
        .WithMany(p => p.Citas)
        .HasForeignKey(p => p.Cit_estadoCita)
        .IsRequired();

        builder.HasOne(p => p.Medico)
        .WithMany(p => p.Citas)
        .HasForeignKey(p => p.Cit_medico)
        .IsRequired();

    }
}
