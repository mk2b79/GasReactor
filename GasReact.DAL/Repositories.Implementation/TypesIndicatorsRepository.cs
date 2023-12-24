using GasReact.DAL.Contexts;
using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GasReact.DAL.Repositories.Implementation;

public class TypesIndicatorsRepository:ITypesIndicatorsRepository
{
    private readonly GasReactorContext _context;

    public TypesIndicatorsRepository(GasReactorContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TypesIndicators>> GetAllAsync()
    {
        return await _context.IndicatorTypes.ToListAsync();
    }
}