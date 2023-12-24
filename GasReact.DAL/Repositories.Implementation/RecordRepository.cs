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

    public async Task<IEnumerable<Record>> GetAllAsync()
    {
        return await _context.Records.Include(r => r.Fermentator)
            .ToListAsync();
    }

    public async Task<Record> GetFullAsync(int id)
    {
        var record = await _context.Records
            .Include(r => r.Fermentator)
            .Include(r => r.Indicators)
            .Where(r => r.RecordId == id)
            .FirstAsync();
        return record;
    }

    public async Task AddAsync(Record record)
    {
        await _context.Records.AddAsync(record);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Record record)
    {
        _context.Records.Remove(record);
        await _context.SaveChangesAsync();
    }
}