using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Acudiente
{
    //atributos de la entidad
    [Key]
    public int Acu_codigo { get; set; }
    public string ? Acu_nombreCompleto { get; set; }
    public string ? Acu_telefono { get; set; }
    public string ? Acu_direccion { get; set; }

    //definimos las ICollection
    public ICollection<Usuario> ? Usuarios { get; set; }
        
}
