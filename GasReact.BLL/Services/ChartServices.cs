using System.Collections;
using GasReact.BLL.DTO;
using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;

namespace GasReact.BLL.Services;

public class ChartServices
{
    private readonly IInicatorRepository _indicatorsRepository;
    
    public ChartServices(IInicatorRepository indicatorsRepository)
    {
        _indicatorsRepository = indicatorsRepository;
    }

    public async Task<IEnumerable<IndicatorChartDto>> GetRangeAsync(FermentatorDto fermentator,
        IndicatorTypeDto indicatorType, DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }
}