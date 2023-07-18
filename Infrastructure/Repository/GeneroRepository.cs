
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class GeneroRepository : IGeneroInterface
{
    protected readonly proyectoAppBackendContext _context;

    public GeneroRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Genero entity)
    {
        _context.Set<Genero>().Add(entity);
    }

    public void AddRange(IEnumerable<Genero> entities)
    {
        _context.Set<Genero>().AddRange(entities);
    }

    public IEnumerable<Genero> Find(Expression<Func<Genero, bool>> expression)
    {
        return _context.Set<Genero>().Where(expression);
    }

    public async Task<IEnumerable<Genero>> GetAllAsync()
    {
        return await _context.Set<Genero>().ToListAsync();
    }

    public async Task<Genero> GetByIdAsync(int id)
    {
        return await _context.Set<Genero>().FindAsync(id);
    }

    public void Remove(Genero entity)
    {
        _context.Set<Genero>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Genero> entities)
    {
        _context.Set<Genero>().RemoveRange(entities);
    }

    public void Update(Genero entity)
    {
        _context.Set<Genero>().Update(entity);
    }
}
