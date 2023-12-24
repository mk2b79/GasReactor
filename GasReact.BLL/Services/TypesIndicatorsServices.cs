using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;

namespace GasReact.BLL.Services;

public class TypesIndicatorsServices
{
    private readonly ITypesIndicatorsRepository _typesIndicatorsRepository;

    public TypesIndicatorsServices(ITypesIndicatorsRepository typesIndicatorsRepository)
    {
        _typesIndicatorsRepository = typesIndicatorsRepository;
    }

    public async Task<IEnumerable<TypesIndicators>> GetAllTypesIndicatorsAsync()
    {
        return await _typesIndicatorsRepository.GetAllAsync();
    }
}