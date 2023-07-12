﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(proyectoAppBackendContext))]
    [Migration("20230712143045_InitialCreateV1")]
    partial class InitialCreateV1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Acudiente", b =>
                {
                    b.Property<int>("Acu_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acu_direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Acu_nombreCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Acu_telefono")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Acu_codigo");

                    b.ToTable("acudiente", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.Property<int>("Cit_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cit_datoUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Cit_estadoCita")
                        .HasColumnType("int");

                    b.Property<DateTime>("Cit_fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("Cit_medico")
                        .HasColumnType("int");

                    b.HasKey("Cit_codigo");

                    b.HasIndex("Cit_datoUsuario");

                    b.HasIndex("Cit_estadoCita");

                    b.HasIndex("Cit_medico");

                    b.ToTable("cita", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Consultorio", b =>
                {
                    b.Property<int>("Cons_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cons_nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Cons_codigo");

                    b.ToTable("consultorio", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Especialidad", b =>
                {
                    b.Property<int>("Esp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Esp_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Esp_id");

                    b.ToTable("espesialidad", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Estado_cita", b =>
                {
                    b.Property<int>("Estcita_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estcita_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Estcita_id");

                    b.ToTable("estado_cita", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Property<int>("Gen_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gen_abreviatura")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Gen_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Gen_id");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Property<int>("Med_nroMatriculaProfesional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Med_consultorio")
                        .HasColumnType("int");

                    b.Property<int>("Med_especialidad")
                        .HasColumnType("int");

                    b.Property<string>("Med_nombreCompleto")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.HasKey("Med_nroMatriculaProfesional");

                    b.HasIndex("Med_consultorio");

                    b.HasIndex("Med_especialidad");

                    b.ToTable("medico", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Tipo_documento", b =>
                {
                    b.Property<int>("Tipdoc_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipdoc_abreviatura")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tipodoc_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Tipdoc_id");

                    b.ToTable("tipo_documento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Property<int>("Usu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usu_acudiente")
                        .HasColumnType("int");

                    b.Property<string>("Usu_direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Usu_email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Usu_genero")
                        .HasColumnType("int");

                    b.Property<string>("Usu_nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usu_primer_apellido_usuar")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usu_segdo_apellido_usuar")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usu_segdo_nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Usu_telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Usu_tipodoc")
                        .HasColumnType("int");

                    b.HasKey("Usu_id");

                    b.HasIndex("Usu_acudiente");

                    b.HasIndex("Usu_email")
                        .IsUnique();

                    b.HasIndex("Usu_genero");

                    b.HasIndex("Usu_tipodoc");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.HasOne("Core.Entities.Usuario", "Usuario")
                        .WithMany("Citas")
                        .HasForeignKey("Cit_datoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Estado_cita", "Estado_Cita")
                        .WithMany("Citas")
                        .HasForeignKey("Cit_estadoCita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Medico", "Medico")
                        .WithMany("Citas")
                        .HasForeignKey("Cit_medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado_Cita");

                    b.Navigation("Medico");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.HasOne("Core.Entities.Consultorio", "Consultorio")
                        .WithMany("Medicos")
                        .HasForeignKey("Med_consultorio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Especialidad", "Especialidad")
                        .WithMany("Medicos")
                        .HasForeignKey("Med_especialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultorio");

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.HasOne("Core.Entities.Acudiente", "Acudiente")
                        .WithMany("Usuarios")
                        .HasForeignKey("Usu_acudiente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Genero", "Genero")
                        .WithMany("Usuarios")
                        .HasForeignKey("Usu_genero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Tipo_documento", "Tipo_Documento")
                        .WithMany("Usuarios")
                        .HasForeignKey("Usu_tipodoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acudiente");

                    b.Navigation("Genero");

                    b.Navigation("Tipo_Documento");
                });

            modelBuilder.Entity("Core.Entities.Acudiente", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Consultorio", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entities.Especialidad", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entities.Estado_cita", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.Tipo_documento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
