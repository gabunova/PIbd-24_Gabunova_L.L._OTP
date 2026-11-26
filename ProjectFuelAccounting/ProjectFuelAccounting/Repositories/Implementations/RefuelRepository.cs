using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class RefuelRepository : IRefuelRepository
{
    private readonly DataContext _context;
    private readonly ILogger<RefuelRepository> _logger;
    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    };

    public RefuelRepository(DataContext context, ILogger<RefuelRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateRefuel(Refuel refuel)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(refuel, _jsonOptions));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Refuels.Add(refuel);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public IEnumerable<Refuel> ReadRefuels(DateTime? dateFrom = null, DateTime? dateTo = null, int? carId = null, int? driverId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var query = _context.Refuels
                .Include(r => r.Driver)
                .Include(r => r.Car)
                .AsNoTracking()
                .AsQueryable();
            if (dateFrom.HasValue)
            {
                var fromUtc = dateFrom.Value.ToUniversalTime();
                query = query.Where(x => x.RefuelDate >= fromUtc);
            }
            if (dateTo.HasValue)
            {
                var toUtc = dateTo.Value.ToUniversalTime();
                query = query.Where(x => x.RefuelDate <= toUtc);
            }
            if (carId.HasValue)
            {
                query = query.Where(x => x.CarsId == carId.Value);
            }
            if (driverId.HasValue)
            {
                query = query.Where(x => x.DriversId == driverId.Value);
            }
            var refuels = query.ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonSerializer.Serialize(refuels, _jsonOptions));
            return refuels;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}