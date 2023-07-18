
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class UsuarioRepository : IUsuarioInterface
{
    protected readonly proyectoAppBackendContext _context;

    public UsuarioRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Usuario entity)
    {
        _context.Set<Usuario>().Add(entity);
    }

    public void AddRange(IEnumerable<Usuario> entities)
    {
        _context.Set<Usuario>().AddRange(entities);
    }

    public IEnumerable<Usuario> Find(Expression<Func<Usuario, bool>> expression)
    {
        return _context.Set<Usuario>().Where(expression);
    }

    public async Task<IEnumerable<Usuario>> GetAllAsync()
    {
        return await _context.Set<Usuario>().ToListAsync();
    }

    public async Task<Usuario> GetByIdAsync(int id)
    {
        return await _context.Set<Usuario>().FindAsync(id);
    }

    public void Remove(Usuario entity)
    {
        _context.Set<Usuario>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Usuario> entities)
    {
        _context.Set<Usuario>().RemoveRange(entities);
    }

    public void Update(Usuario entity)
    {
        _context.Set<Usuario>().Update(entity);
    }
}
