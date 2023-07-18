
namespace Core.Interfaces;

public interface IUnitOfWorkInterface
{
    //implemtamos las interfaces creadas
    IAcudienteInterface Acudientes { get; set; }
    ICitaInterface Citas { get; set; }
    IConsultorioInterface Consultorios { get; set; }
    IEspecialidadInterface Especialidades { get; set; }
    IEstado_citaInterface Estados_citas { get; set; }
    IGeneroInterface Generos { get; set; }
    IMedicoInterface Medicos { get; set; }
    ITipo_documentoInterface Tipos_documentos { get; set; }
    IUsuarioInterface Usuarios { get; set; }

    Task<int> SaveAsync();
        
}
