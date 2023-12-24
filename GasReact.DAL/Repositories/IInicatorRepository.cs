using GasReact.DAL.Entities;

namespace GasReact.DAL.Repositories;

public interface IInicatorRepository
{
    Task<IEnumerable<Indicator>> GetAllAsync();
}