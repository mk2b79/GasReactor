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
        Random random = new Random();
        List<IndicatorChartDto> records = new List<IndicatorChartDto>
        {
            new IndicatorChartDto { Value = random.Next(0,100), Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = random.Next(0,100), Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = random.Next(0,100), Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = random.Next(0,100), Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = random.Next(0,100), Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = random.Next(0,100), Date = new DateTime(2023, 1, 1) }
        };
        return records;
    }
}