
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IUsuarioInterface
{
    //implemtamos los metodos del CRUD
    Task<Usuario> GetByIdAsync(int id);
    Task<IEnumerable<Usuario>> GetAllAsync();
    IEnumerable<Usuario> Find(Expression<Func<Usuario, bool>> expression);
    void Add(Usuario entity);
    void AddRange(IEnumerable<Usuario> entities);
    void Remove(Usuario entity);
    void RemoveRange(IEnumerable<Usuario> entities);
    void Update(Usuario entity);

}
