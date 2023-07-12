using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Especialidad
{
    //atributos de la entidad
    [Key]
    public int Esp_id { get; set; }
    public string ? Esp_nombre { get; set; }
    
        
}
