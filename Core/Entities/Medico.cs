using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Medico
{
    //atributos de las entidades
    [Key]
    public int Med_nroMatriculaProfesional { get; set; }
    public string ? Med_nombreCompleto { get; set; }
    public int Med_consultorio { get; set; }
    public int Med_especialidad { get; set; }

    //definimos las ICollection
    public ICollection<Cita> ? Citas { get; set; }

    //definimoas las referencias
    public Especialidad ? Especialidad { get; set; }
    public Consultorio ? Consultorio { get; set; }

        
}
