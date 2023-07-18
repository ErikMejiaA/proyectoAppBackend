
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IMedicoInterface
{
    //implementmos los metodos del CRUD 
    Task<Medico> GetByIdaAsync(int id);
    Task<IEnumerable<Medico>> GetAllAsync();
    IEnumerable<Medico> Find(Expression<Func<Medico, bool>> expression);
    void Add(Medico entity);
    void AddRange(IEnumerable<Medico> entities);
    void Remove(Medico entity);
    void RemoveRange(IEnumerable<Medico> entities);
    void Update(Medico entity);
    
}
