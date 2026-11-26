using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Car
{
    [Key]
    public int Id { get; internal set; }

    [Required]
    public string Brand { get; internal set; } = string.Empty;

    [Required]
    [Column("CarNumber")]
    public string CarNumber { get; internal set; } = string.Empty;

    public double FuelRate { get; internal set; }
    public VehicleCategory Category { get; internal set; }

    public Car() { }

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

    public override string ToString() => $"{Brand} ({CarNumber})";
}