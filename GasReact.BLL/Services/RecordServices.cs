using GasReact.DAL.Entities;
using GasReact.DAL.Repositories;

namespace GasReact.BLL.Services;

public class RecordServices
{
    private readonly IRecordRepository _recordRepository;

    public RecordServices(IRecordRepository recordRepository)
    {
        _recordRepository = recordRepository;
    }

    public async Task<Record> GetFullRecordAsync(int id)
    {
        return await _recordRepository.GetFullAsync(id);
    }

    public async Task<IEnumerable<Record>> GetAllRecordAsync()
    {
        return await _recordRepository.GetAllAsync();
    }

    public async Task AddRecordAsync(Record record)
    {
        await _recordRepository.AddAsync(record);
    }

    public async Task DeleteRecord(Record record)
    {
        await _recordRepository.DeleteAsync(record);
    }
}