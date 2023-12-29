using GasReact.DAL.Contexts;
using GasReact.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GasReact.DAL.Repositories.Implementation;

public class RecordRepository:IRecordRepository
{
    private GasReactorContext _context;

    public RecordRepository(GasReactorContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Node>> GetAllAsync()
    {
        return await _context.Nodes.Include(r => r.Fermentator)
            .ToListAsync();
    }

    public async Task<Node> GetFullAsync(int id)
    {
        var record = await _context.Nodes
            .Include(r => r.Fermentator)
            .Include(r => r.Indicators)
            .Where(r => r.RecordId == id)
            .FirstAsync();
        return record;
    }

    public async Task AddAsync(Node node)
    {
        await _context.Nodes.AddAsync(node);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Node node)
    {
        _context.Nodes.Remove(node);
        await _context.SaveChangesAsync();
    }
}