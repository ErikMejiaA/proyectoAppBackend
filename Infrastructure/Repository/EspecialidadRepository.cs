
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class EspecialidadRepository : IEspecialidadInterface
{
    protected readonly proyectoAppBackendContext _context;

    public EspecialidadRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Especialidad entity)
    {
        _context.Set<Especialidad>().Add(entity);
    }

    public void AddRange(IEnumerable<Especialidad> entities)
    {
        _context.Set<Especialidad>().AddRange(entities);
    }

    public IEnumerable<Especialidad> Find(Expression<Func<Especialidad, bool>> expression)
    {
        return _context.Set<Especialidad>().Where(expression);
    }

    public async Task<IEnumerable<Especialidad>> GetAllAsync()
    {
        return await _context.Set<Especialidad>().ToListAsync();
    }

    public async Task<Especialidad> GetByIdAsync(int id)
    {
        return await _context.Set<Especialidad>().FindAsync(id);
    }

    public void Remove(Especialidad entity)
    {
        _context.Set<Especialidad>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Especialidad> entities)
    {
        _context.Set<Especialidad>().RemoveRange(entities);
    }

    public void Update(Especialidad entity)
    {
        _context.Set<Especialidad>().Update(entity);
    }
}
