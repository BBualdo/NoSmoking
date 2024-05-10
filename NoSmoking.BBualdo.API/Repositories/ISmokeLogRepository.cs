using NoSmoking.BBualdo.API.Models;

namespace NoSmoking.BBualdo.API.Repositories;

public interface ISmokeLogRepository
{
  Task<IEnumerable<SmokeLog>> GetSmokeLogs();
  Task<SmokeLog?> GetSmokeLog(int id);
  Task AddSmokeLog(SmokeLog smokeLog);
  Task UpdateSmokeLog(SmokeLog smokeLog);
  Task DeleteSmokeLog(int id);
}
