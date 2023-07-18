
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IEstado_citaInterface
{
    //implementamos los metodos del CRUD 
    Task<Estado_cita> GetByIdAsync(int id);
    Task<IEnumerable<Estado_cita>> GetAllAsync();
    IEnumerable<Estado_cita> Find(Expression<Func<Estado_cita, bool>> expression);
    void Add(Estado_cita entity);
    void AddRange(IEnumerable<Estado_cita> entities);
    void Remove(Estado_cita entity);
    void RemoveRange(IEnumerable<Estado_cita> entities);
    void Update(Estado_cita entity);
        
}
