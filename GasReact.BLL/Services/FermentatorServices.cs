using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;

namespace GasReact.BLL.Services;

public class FermentatorServices
{
    private readonly IFermentatorRepository _fermentatorRepository;

    public FermentatorServices(IFermentatorRepository fermentatorRepository)
    {
        _fermentatorRepository = fermentatorRepository;
    }

    public async Task<IEnumerable<Fermentator>> GetAllFermentatorsAsync()
    {
        return await _fermentatorRepository.GetAllAsync();
    }
}