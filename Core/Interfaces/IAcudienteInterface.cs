
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IAcudienteInterface
{
    //Implementamos los metodos del CRUD 
    Task<Acudiente> GetByIdAsync(int id);
    Task<IEnumerable<Acudiente>> GetAllAsync();
    IEnumerable<Acudiente> Find(Expression<Func<Acudiente, bool>> expression);
    void Add(Acudiente entity);
    void AddRange(IEnumerable<Acudiente> entities);
    void Remove(Acudiente entity);
    void RemoveRange(IEnumerable<Acudiente> entities);
    void Update(Acudiente entity);
        
}
