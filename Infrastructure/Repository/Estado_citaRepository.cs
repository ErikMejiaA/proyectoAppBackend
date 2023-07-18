
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Estado_citaRepository : IEstado_citaInterface
{
    protected readonly proyectoAppBackendContext _context;

    public Estado_citaRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Estado_cita entity)
    {
        _context.Set<Estado_cita>().Add(entity);
    }

    public void AddRange(IEnumerable<Estado_cita> entities)
    {
        _context.Set<Estado_cita>().AddRange(entities);
    }

    public IEnumerable<Estado_cita> Find(Expression<Func<Estado_cita, bool>> expression)
    {
        return _context.Set<Estado_cita>().Where(expression);
    }

    public async Task<IEnumerable<Estado_cita>> GetAllAsync()
    {
        return await _context.Set<Estado_cita>().ToListAsync();
    }

    public async Task<Estado_cita> GetByIdAsync(int id)
    {
        return await _context.Set<Estado_cita>().FindAsync(id);
    }

    public void Remove(Estado_cita entity)
    {
        _context.Set<Estado_cita>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Estado_cita> entities)
    {
        _context.Set<Estado_cita>().RemoveRange(entities);
    }

    public void Update(Estado_cita entity)
    {
        _context.Set<Estado_cita>().Update(entity);
    }
}
