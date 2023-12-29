using GasReact.DAL.Entities;

namespace GasReact.DAL.Repositories;

public interface IRecordRepository
{
    Task<IEnumerable<Node>> GetAllAsync();
    Task<Node> GetFullAsync(int id);
    Task AddAsync(Node node);
    Task DeleteAsync(Node node);
}