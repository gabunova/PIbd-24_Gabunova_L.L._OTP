using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class CarRepository : ICarRepository
{
    private readonly DataContext _context;
    private readonly ILogger<CarRepository> _logger;

    public CarRepository(DataContext context, ILogger<CarRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateCar(Car car)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(car));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void UpdateCar(Car car)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(car));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Cars.Update(car);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteCar(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            _context.ChangeTracker.Clear();
            var car = _context.Cars.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Car ReadCarById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var car = _context.Cars.AsNoTracking().FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _logger.LogDebug("Найденный объект: {json}", JsonSerializer.Serialize(car));
            return car;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Car> ReadCars()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var cars = _context.Cars.AsNoTracking().ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonSerializer.Serialize(cars));
            return cars;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}