
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CitaRepository : ICitaInterface
{
    protected readonly proyectoAppBackendContext _context;

    public CitaRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Cita entity)
    {
        _context.Set<Cita>().Add(entity);
    }

    public void AddRange(IEnumerable<Cita> entities)
    {
        _context.Set<Cita>().AddRange(entities);
    }

    public IEnumerable<Cita> Find(Expression<Func<Cita, bool>> expression)
    {
        return _context.Set<Cita>().Where(expression);
    }

    public async Task<IEnumerable<Cita>> GetAllAsync()
    {
        return await _context.Set<Cita>().ToListAsync();
    }

    public async Task<Cita> GetByIdAsync(int id)
    {
        return await _context.Set<Cita>().FindAsync(id);
    }

    public void Remove(Cita entity)
    {
        _context.Set<Cita>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Cita> entities)
    {
        _context.Set<Cita>().RemoveRange(entities);
    }

    public void Update(Cita entity)
    {
        _context.Set<Cita>().Update(entity);
    }
}
