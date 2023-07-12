using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Usuario
{
    //atributos de la entidad
    [Key]
    public int Usu_id { get; set; }
    public string ? Usu_nombre { get; set; }
    public string ? Usu_segdo_nombre { get; set; }
    public string ? Usu_primer_apellido_usuar { get; set; }
    public string ? Usu_segdo_apellido_usuar { get; set; }
    public string ? Usu_telefono { get; set; }
    public string ? Usu_direccion { get; set; }
    public string ? Usu_email { get; set;}
    public int Usu_tipodoc { get; set; }
    public int Usu_genero { get; set; }
    public int Usu_acudiente { get; set; }

    //definimos las ICollection
    public ICollection<Cita> ? Citas { get; set; }

    //definimos las referencia 
    public Tipo_documento ? Tipo_Documento { get; set; }
    public Genero ? Genero { get; set; }
    public Acudiente ? Acudiente { get; set; }


        
}
