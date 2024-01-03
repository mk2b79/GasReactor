using AutoMapper;
using GasReact.BLL.DTO;
using GasReact.DAL.Entities;

namespace GasReact.BLL.Mapping;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Indicator, IndicatorChartDto>();
    }
}