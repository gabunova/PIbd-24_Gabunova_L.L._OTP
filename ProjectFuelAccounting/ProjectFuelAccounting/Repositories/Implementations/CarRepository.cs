using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class CarRepository : ICarRepository
{
    public void CreateCar(Car car)
    {
    }

    public void DeleteCar(int id)
    {
    }

    public Car ReadCarById(int id)
    {
        return Car.CreateEntity(0, string.Empty, string.Empty, 0, VehicleCategory.None);
    }

    public IEnumerable<Car> ReadCars()
    {
        return [];
    }

    public void UpdateCar(Car car)
    {
    }
}