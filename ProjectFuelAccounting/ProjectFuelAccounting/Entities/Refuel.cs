using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFuelAccounting.Entities;

public class Refuel
{
    [Key]
    public int Id { get; internal set; }

    [ForeignKey(nameof(Car))]
    public int CarsId { get; internal set; }

    [ForeignKey(nameof(Driver))]
    public int DriversId { get; internal set; }

    public DateTime RefuelDate { get; internal set; }

    [Column("FuelAmount")]
    public double FuelAmount { get; internal set; }

    public Car? Car { get; internal set; }
    public Driver? Driver { get; internal set; }

    public Refuel() { }

    public static Refuel CreateOperation(int id, int carsId, int driversId, double fuelAmount)
    {
        return new Refuel
        {
            Id = id,
            CarsId = carsId,
            DriversId = driversId,
            RefuelDate = DateTime.UtcNow,
            FuelAmount = fuelAmount
        };
    }
}