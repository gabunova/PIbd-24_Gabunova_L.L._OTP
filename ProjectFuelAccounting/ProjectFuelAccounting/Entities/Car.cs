using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Car
{
    public int Id { get; private set; }
    public string Brand { get; private set; } = string.Empty;
    public string CarNumber { get; private set; } = string.Empty;
    public FuelType FuelType { get; private set; }
    public VehicleCategory RequiredCategory { get; private set; }

    public static Car CreateEntity(int id, string brand, string carNumber, double fuelConsumptionRate, FuelType fuelType, VehicleCategory requiredCategory)
    {
        return new Car
        {
            Id = id,
            Brand = brand ?? string.Empty,
            CarNumber = carNumber ?? string.Empty,
            FuelType = fuelType,
            RequiredCategory = requiredCategory
        };
    }
}