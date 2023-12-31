using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("medico");

        builder.Property(p => p.Med_nroMatriculaProfesional)
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p => p.Med_nombreCompleto)
        .IsRequired()
        .HasMaxLength(120);

        //creamos las FOREGIN KEY
        builder.HasOne(p => p.Especialidad)
        .WithMany(p => p.Medicos)
        .HasForeignKey(p => p.Med_especialidad)
        .IsRequired();

        builder.HasOne(p => p.Consultorio)
        .WithMany(p => p.Medicos)
        .HasForeignKey(p => p.Med_consultorio)
        .IsRequired();

    }
}
