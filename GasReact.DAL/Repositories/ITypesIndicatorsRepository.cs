using GasReact.DAL.Entities;

namespace GasReact.DAL.Repositories;

public interface ITypesIndicatorsRepository
{
    Task<IEnumerable<TypesIndicators>> GetAllAsync();
}