using GasReact.DAL.Contexts;
using GasReact.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GasReact.DAL.Repositories.Implementation;

public class FermentatorRepository:IFermentatorRepository
{
    private readonly GasReactorContext _context;

    public FermentatorRepository(GasReactorContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Fermentator>> GetAllAsync()
    {
        return await _context.Fermentators.ToListAsync();
    }

    public async Task AddAsync(Fermentator fermentator)
    {
        await _context.Fermentators.AddAsync(fermentator);
    }
}