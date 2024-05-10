using NoSmoking.BBualdo.API.Models;

namespace NoSmoking.BBualdo.API.Repositories;

public interface ISmokeLogRepository
{
  Task<IEnumerable<SmokeLog>> GetSmokeLogs();
  Task<SmokeLog?> GetSmokeLog(int id);
  Task AddSmokeLog(SmokeLogDTO smokeLog);
  Task UpdateSmokeLog(int id, SmokeLogDTO smokeLog);
  Task DeleteSmokeLog(int id);
}
