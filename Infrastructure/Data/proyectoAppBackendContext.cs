using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class proyectoAppBackendContext : DbContext
{
    public proyectoAppBackendContext(DbContextOptions<proyectoAppBackendContext> options) : base(options)
    {

    }

    //se ecriben lo DbSet<Entidad>
    public DbSet<Acudiente> ? Acudientes { get; set; }
    public DbSet<Consultorio> ? Consultorios { get; set; }
    public DbSet<Especialidad> ? Especialidades { get; set; }
    public DbSet<Estado_cita> ? Estados_Citas { get; set; }
    public DbSet<Genero> ? Generos { get; set; }
    public DbSet<Medico> ? Medicos { get; set; }
    public DbSet<Tipo_documento> ? Tipos_Documentos { get; set; }
    public DbSet<Usuario> ? Usuarios { get; set; }
    
    //Codigo para poder cargar de forma automatica las configuraciones 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
