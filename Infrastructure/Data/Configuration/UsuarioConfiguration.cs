using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
    {
        //definimos las propiedades a los atributos de la entidad

        builder.ToTable("usuario");

        builder.Property(p => p.Usu_id)
        .IsRequired();

        builder.Property(p => p.Usu_nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Usu_segdo_nombre)
        .IsRequired()
        .HasMaxLength(45);

        builder.Property(p => p.Usu_primer_apellido_usuar)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Usu_segdo_apellido_usuar)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Usu_telefono)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Usu_direccion)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Usu_email)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex(p => p.Usu_email)
        .IsUnique();

        //creamos las llaves FOREIGN KEY

        builder.HasOne(p => p.Tipo_Documento)
        .WithMany(p => p.Usuarios)
        .HasForeignKey(p => p.Usu_tipodoc)
        .IsRequired();

        builder.HasOne(p => p.Genero)
        .WithMany(p => p.Usuarios)
        .HasForeignKey(p => p.Usu_genero)
        .IsRequired();

        builder.HasOne(p => p.Acudiente)
        .WithMany(p => p.Usuarios)
        .HasForeignKey(p => p.Usu_acudiente)
        .IsRequired();

    }
}
