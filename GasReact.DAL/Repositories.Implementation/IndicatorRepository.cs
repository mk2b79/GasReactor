using GasReact.DAL.Contexts;
using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GasReact.DAL.Repositories.Implementation;

public class IndicatorRepository:IInicatorRepository
{
    private GasReactorContext _context;

    public IndicatorRepository(GasReactorContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Indicator>> GetAllAsync()
    {
        return await _context.Indicators.ToListAsync();
    }
}