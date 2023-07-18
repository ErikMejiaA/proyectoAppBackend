
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Tipo_documentoRepository : ITipo_documentoInterface
{
    protected readonly proyectoAppBackendContext _context;

    public Tipo_documentoRepository(proyectoAppBackendContext context)
    {
        _context = context;
    }

    public void Add(Tipo_documento entity)
    {
        _context.Set<Tipo_documento>().Add(entity);
    }

    public void AddRange(IEnumerable<Tipo_documento> entities)
    {
        _context.Set<Tipo_documento>().AddRange(entities);
    }

    public IEnumerable<Tipo_documento> Find(Expression<Func<Tipo_documento, bool>> expression)
    {
        return _context.Set<Tipo_documento>().Where(expression);
    }

    public async Task<IEnumerable<Tipo_documento>> GetAllAsync()
    {
        return await _context.Set<Tipo_documento>().ToListAsync();
    }

    public async Task<Tipo_documento> GetByIdAsync(int id)
    {
        return await _context.Set<Tipo_documento>().FindAsync(id);
    }

    public void Remove(Tipo_documento entity)
    {
        _context.Set<Tipo_documento>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Tipo_documento> entities)
    {
        _context.Set<Tipo_documento>().RemoveRange(entities);
    }

    public void Update(Tipo_documento entity)
    {
        _context.Set<Tipo_documento>().Update(entity);
    }
}
