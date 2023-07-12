using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class proyectoAppBackendContext : DbContext
{
    public proyectoAppBackendContext(DbContextOptions<proyectoAppBackendContext> options) : base(options)
    {

    }

    //se ecriben lo DbSet<Entidad>



    //Codigo para poder ver las entidades en la vase de datos 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
