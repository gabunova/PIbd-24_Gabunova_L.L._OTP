using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class ShiftRepository : IShiftRepository
{
    private readonly DataContext _context;
    private readonly ILogger<ShiftRepository> _logger;
    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    };

    public ShiftRepository(DataContext context, ILogger<ShiftRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateShift(Shift shift)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(shift, _jsonOptions));
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.ChangeTracker.Clear();
            var shiftRoutes = shift.ShiftRoutes.ToList();
            shift.ShiftRoutes = [];

            _context.Shifts.Add(shift);
            _context.SaveChanges();

            foreach (var route in shiftRoutes)
            {
                route.ShiftsId = shift.Id;
                _context.ShiftRoutes.Add(route);
            }
            _context.SaveChanges();

            transaction.Commit();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteShift(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            _context.ChangeTracker.Clear();
            var shift = _context.Shifts.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _context.Shifts.Remove(shift);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<Shift> ReadShifts(DateTime? dateFrom = null, DateTime? dateTo = null, int? driverId = null, int? carId = null, int? routeId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var query = _context.Shifts
                .Include(s => s.Driver)
                .Include(s => s.Car)
                .Include(s => s.ShiftRoutes)
                .AsNoTracking()
                .AsQueryable();
            if (dateFrom.HasValue)
            {
                var fromUtc = dateFrom.Value.ToUniversalTime();
                query = query.Where(x => x.ShiftDate >= fromUtc);
            }
            if (dateTo.HasValue)
            {
                var toUtc = dateTo.Value.ToUniversalTime();
                query = query.Where(x => x.ShiftDate <= toUtc);
            }
            if (driverId.HasValue)
            {
                query = query.Where(x => x.DriversId == driverId.Value);
            }
            if (carId.HasValue)
            {
                query = query.Where(x => x.CarsId == carId.Value);
            }
            if (routeId.HasValue)
            {
                query = query.Where(x => x.ShiftRoutes.Any(sr => sr.RoutesId == routeId.Value));
            }
            var shifts = query.ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonSerializer.Serialize(shifts, _jsonOptions));
            return shifts;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}