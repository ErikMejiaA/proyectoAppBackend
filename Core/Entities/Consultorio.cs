using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Consultorio
{
    //atributos de la entidad
    [Key]
    public int Cons_codigo { get; set; }
    public string ? Cons_nombre { get; set; }

        
}
