using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Tipo_documento
{
    //atributos de la entidad
    [Key]
    public int Tipdoc_id { get; set; }
    public string ? Tipodoc_nombre { get; set; }
    public string ? Tipdoc_abreviatura { get; set; }

    //definimos las ICollection
    public ICollection<Usuario> ? Usuarios { get; set; }
        
}
