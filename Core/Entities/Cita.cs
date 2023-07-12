using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Cita
{
    //atributos de la entidad
    [Key]
    public int Cit_codigo { get; set; }
    public DateTime Cit_fecha { get; set; }
    public int Cit_estado { get; set; }
    public int Cit_medico { get; set; }
    public int Cit_datoUsuario { get; set; }

    //definimos las referencias 
    public Usuario ? Usuario { get; set; }
    public Estado_cita ? Estado_Cita { get; set; }
    public Medico ? Medico { get; set; }
    

        
}
