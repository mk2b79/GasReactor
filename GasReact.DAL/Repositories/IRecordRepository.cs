using GasReact.DAL.Entities;

namespace GasReact.DAL.Repositories;

public interface IRecordRepository
{
    Task<IEnumerable<Record>> GetAllAsync();
    Task<Record> GetFullAsync(int id);
    Task AddAsync(Record record);
    Task DeleteAsync(Record record);
}