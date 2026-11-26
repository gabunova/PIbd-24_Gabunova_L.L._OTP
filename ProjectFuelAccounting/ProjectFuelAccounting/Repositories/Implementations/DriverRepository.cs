using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class DriverRepository : IDriverRepository
{
    private readonly DataContext _context;
    private readonly ILogger<DriverRepository> _logger;

    public DriverRepository(DataContext context, ILogger<DriverRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateDriver(Driver driver)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(driver));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void UpdateDriver(Driver driver)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(driver));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Drivers.Update(driver);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteDriver(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            _context.ChangeTracker.Clear();
            var driver = _context.Drivers.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _context.Drivers.Remove(driver);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Driver ReadDriverById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var driver = _context.Drivers.AsNoTracking().FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _logger.LogDebug("Найденный объект: {json}", JsonSerializer.Serialize(driver));
            return driver;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Driver> ReadDrivers()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var drivers = _context.Drivers.AsNoTracking().ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonSerializer.Serialize(drivers));
            return drivers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}