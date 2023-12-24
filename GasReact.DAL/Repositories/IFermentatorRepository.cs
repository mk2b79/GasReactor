using GasReact.DAL.Entities;

namespace GasReact.DAL.Repositories;

public interface IFermentatorRepository
{ 
    Task<IEnumerable<Fermentator>> GetAllAsync();
    Task AddAsync(Fermentator fermentator);
}