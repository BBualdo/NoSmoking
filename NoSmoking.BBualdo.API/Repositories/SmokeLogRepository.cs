using NoSmoking.BBualdo.API.Models;

namespace NoSmoking.BBualdo.API.Repositories;

public class SmokeLogRepository : ISmokeLogRepository
{
  public Task AddSmokeLog(SmokeLogDTO smokeLog)
  {
    throw new NotImplementedException();
  }

  public Task DeleteSmokeLog(int id)
  {
    throw new NotImplementedException();
  }

  public Task<SmokeLog?> GetSmokeLog(int id)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<SmokeLog>> GetSmokeLogs()
  {
    throw new NotImplementedException();
  }

  public Task UpdateSmokeLog(int id, SmokeLogDTO smokeLog)
  {
    throw new NotImplementedException();
  }
}
