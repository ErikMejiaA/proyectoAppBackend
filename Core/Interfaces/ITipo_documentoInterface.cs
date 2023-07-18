
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITipo_documentoInterface
{
    //implemtamos los metodos del CRUD 
    Task<Tipo_documento> GetByIdAsync(int id);
    Task<IEnumerable<Tipo_documento>> GetAllAsync();
    IEnumerable<Tipo_documento> Find(Expression<Func<Tipo_documento, bool>> expression);
    void Add(Tipo_documento entity);
    void AddRange(IEnumerable<Tipo_documento> entities);
    void Remove(Tipo_documento entity);
    void RemoveRange(IEnumerable<Tipo_documento> entities);
    void Update(Tipo_documento entity);
    
}
