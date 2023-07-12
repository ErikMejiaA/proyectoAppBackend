using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Genero
{
    //atributos de la entidad
    [Key]
    public int Gen_id { get; set; }
    public string ? Gen_nombre { get; set; }
    public string ? Gen_abreviatura { get; set; }

    //definimos las ICollection
    public ICollection<Usuario> ? Usuarios { get; set; }

        
}
