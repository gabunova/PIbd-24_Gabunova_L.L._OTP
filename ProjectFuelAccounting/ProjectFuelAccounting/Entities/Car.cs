using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Car
{
    public int Id { get; private set; }
    public string Brand { get; private set; } = string.Empty;
    public string CarNumber { get; private set; } = string.Empty;
    public double FuelRate { get; private set; }
    public VehicleCategory Category { get; private set; }

    public static Car CreateEntity(int id, string brand, string carNumber, double fuelRate, VehicleCategory category)
    {
        return new Car
        {
            Id = id,
            Brand = brand ?? string.Empty,
            CarNumber = carNumber ?? string.Empty,
            FuelRate = fuelRate,
            Category = category
        };
    }
}