
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class MedicoRepository : IMedicoInterface
{
    protected readonly proyectoAppBackendContext _context;

    public MedicoRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Medico entity)
    {
        _context.Set<Medico>().Add(entity);
    }

    public void AddRange(IEnumerable<Medico> entities)
    {
        _context.Set<Medico>().AddRange(entities);
    }

    public IEnumerable<Medico> Find(Expression<Func<Medico, bool>> expression)
    {
        return _context.Set<Medico>().Where(expression);
    }

    public async Task<IEnumerable<Medico>> GetAllAsync()
    {
        return await _context.Set<Medico>().ToListAsync();
    }

    public async Task<Medico> GetByIdaAsync(int id)
    {
        return await _context.Set<Medico>().FindAsync(id);
    }

    public void Remove(Medico entity)
    {
        _context.Set<Medico>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Medico> entities)
    {
        _context.Set<Medico>().RemoveRange(entities);
    }

    public void Update(Medico entity)
    {
        _context.Set<Medico>().Update(entity);
    }
}
