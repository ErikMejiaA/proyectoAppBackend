using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Estado_cita
{
    //atributos de la entidad
    [Key]
    public int Estcita_id { get; set; }
    public string ? Estcita_nombre { get; set; }

    //definimos las ICollection
    public ICollection<Cita> ? Citas { get; set; }

        
}
