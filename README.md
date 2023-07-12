# proyectoAppBackend
proyecto de preactica Entity Framework, Conexion a base de datos 

pasos llevados a cavo 

1. Creaccion del repositoria en git y luego su clonacion en el ecritorio, utilizando el comado:
-> git clone "URL"

2. Luego ingresamos a la carpeta creada, mediante el comando:
-> cd proyectoBackEnd

3. Ahora creamos la solución (sln) a la carpeta del proyecto creada, la cual permite enumerar y modificar los proyectos, ejecutamos siguiente comando:
-> dotnet new sln

4. Creamos la carpeta proyecto de webapi, la cual contendrá los EndPoints y las Apis para ser consumidas, ejecutamos el siguiente comando:
-> dotnet new webapi -o API  
=> el -o me permite hacer referencia a la carpeta creada.

5. Ahora para la carpeta creada (API), la asociamos a la solución (sln) global, ejecutamos el siguiente comando:
-> dotnet sln add .\API\

6. Creamos la carpeta de proyecto Core, la cual va ha contener las clases (Entidades) e interfases del proyecto, ejecutamos el siguiente comando:
-> dotnet new classlib -o Core

7. Ahora agregamos la carpeta creada Core a la solución (sln) global, ejecutamos el siguiente comando:
-> dotnet sln add .\Core\

8. Creamos la carpeta Infrastructure, que contendrá lo relacionado a la unidad de trabajo, repositorios y acceso de datos, ejecutamos el siguiente comando:
->  dotnet new classlib -o Infrastructure

9. Ahora agregamos la carpeta Infrastructure a la solución (sln) global, ejecutamos el siguiente comando:
-> dotnet sln add .\Infrastructure\

10. Creamos las relaciones entre Infrastructure con la de Core, para ello ingresamos a la carpeta de Infrastructure y ejecutamos el siguiente comando
-> dotnet add reference ..\Core\

11. Después creamos la relacion entre la carpeta API con la de Infrastructure, para ello ingresamos a la carpeta de API y ejecutamos el siguiente comando:
-> dotnet add reference ..\Infrastructure\

12. ahora dentro de la carpeta Infrastructure anexamos los paquetes de Microsoft.Ent, Misql. estos paquetes se deben descargar de la pagina de Nuget.org y se deben buscar dentro de la barra del buscador. 

13. ahora dentro de la carpeta de API anexamos el paquete de Design y el de Microsoft.Ent. Hacer el mismo procedimiento del punto anterior. 

14. luego ya estando en el entorno del proyecto, creamos la clase DbContext,  dentro de la carpeta Infrastructure se crea la carpeta Data y alli se crea la clase. luego se le añade la Herencia de la clase DbContext.

=> ahora creamos el constructor de la clase, para ello damos click dentro de la clase y seleccionamos refractor y luego en generar constructor <option> 

=> ahora establecemos las referencias (get y set) a cada una de las entidades creadas, para ello se implementa la DbSet<Entidad> para referenciar a cada una de ellas.

=> copiamos el siguiente comando para poder enviar las entidades
protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       base.OnModelCreating(modelBuilder);
       modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
   }

15. creamos una variable de conexion a la base datos