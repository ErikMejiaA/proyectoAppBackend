
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ICitaInterface
{
    //Implemetamos los metodos del CRUD 
    Task<Cita> GetByIdAsync(int id);
    Task<IEnumerable<Cita>> GetAllAsync();
    IEnumerable<Cita> Find(Expression<Func<Cita, bool>> expression);
    void Add(Cita entity);
    void AddRange(IEnumerable<Cita> entities);
    void Remove(Cita entity);
    void RemoveRange(IEnumerable<Cita> entities);
    void Update(Cita entity);
        
}
