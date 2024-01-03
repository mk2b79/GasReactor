using System.Collections;
using AutoMapper;
using GasReact.BLL.DTO;
using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;

namespace GasReact.BLL.Services;

public class ChartServices
{
    private readonly IInicatorRepository _indicatorsRepository;
    private readonly IMapper _mapper;
    
    public ChartServices(IInicatorRepository indicatorsRepository, IMapper mapper)
    {
        _indicatorsRepository = indicatorsRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<IndicatorChartDto>> GetRangeAsync(int fermentatorId,
        int indicatorTypeId, DateTime startDate, DateTime endDate)
    {
        //Return test data
        return testData();
    }

    private IEnumerable<IndicatorChartDto> testData()
    {
        List<IndicatorChartDto> records = new List<IndicatorChartDto>
        {
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) }
        };
        return records;
    }
}