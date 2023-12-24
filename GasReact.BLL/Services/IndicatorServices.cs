using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;

namespace GasReact.BLL.Services;

public class IndicatorServices
{
    private readonly IInicatorRepository _indicatorsRepository;

    public IndicatorServices(IInicatorRepository indicatorsRepository)
    {
        _indicatorsRepository = indicatorsRepository;
    }

    public async Task<IEnumerable<Indicator>> GetAllIndicatorsAsync()
    {
        return await _indicatorsRepository.GetAllAsync();
    }
}