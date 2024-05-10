using Microsoft.EntityFrameworkCore;
using NoSmoking.BBualdo.API.Data;
using NoSmoking.BBualdo.API.Models;

namespace NoSmoking.BBualdo.API.Repositories;

public class SmokeLogRepository : ISmokeLogRepository
{
  private readonly SmokeLogsContext _context;

  public SmokeLogRepository(SmokeLogsContext context)
  {
    _context = context;
  }

  public async Task AddSmokeLog(SmokeLog smokeLog)
  {
    await _context.Records.AddAsync(smokeLog);
    await _context.SaveChangesAsync();
  }

  public async Task DeleteSmokeLog(int id)
  {
    SmokeLog logToDelete = await _context.Records.SingleAsync(x => x.Id == id);
    _context.Records.Remove(logToDelete);
    await _context.SaveChangesAsync();
  }

  public async Task<SmokeLog?> GetSmokeLog(int id)
  {
    return await _context.Records.FindAsync(id);
  }

  public async Task<IEnumerable<SmokeLog>> GetSmokeLogs()
  {
    return await _context.Records.ToListAsync();
  }

  public async Task UpdateSmokeLog(SmokeLog smokeLog)
  {
    _context.Entry(smokeLog).State = EntityState.Modified;
    await _context.SaveChangesAsync();
  }
}
