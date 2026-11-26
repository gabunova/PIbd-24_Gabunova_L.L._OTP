using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFuelAccounting.Entities;

public class ShiftRoute
{
    [Key]
    public int Id { get; internal set; }

    [ForeignKey(nameof(Shift))]
    public int ShiftsId { get; internal set; }

    [ForeignKey(nameof(Route))]
    public int RoutesId { get; internal set; }

    [Column("FuelSpent")]
    public double FuelSpent { get; internal set; }

    public Shift? Shift { get; internal set; }
    public Route? Route { get; internal set; }

    public ShiftRoute() { }

    public static ShiftRoute CreateElement(int id, int routesId, double fuelSpent)
    {
        return new ShiftRoute
        {
            Id = id,
            RoutesId = routesId,
            FuelSpent = fuelSpent
        };
    }
}