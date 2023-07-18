
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IEspecialidadInterface
{
    //Implemtamos los metodos del CRUD
    Task<Especialidad> GetByIdAsync(int id);
    Task<IEnumerable<Especialidad>> GetAllAsync();
    IEnumerable<Especialidad> Find(Expression<Func<Especialidad, bool>> expression);
    void Add(Especialidad entity);
    void AddRange(IEnumerable<Especialidad> entities);
    void Remove(Especialidad entity);
    void RemoveRange(IEnumerable<Especialidad> entities);
    void Update(Especialidad entity);
 
}
