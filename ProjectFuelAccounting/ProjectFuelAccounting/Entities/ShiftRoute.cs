namespace ProjectFuelAccounting.Entities;

public class ShiftRoute
{
    public int Id { get; private set; }
    public int RoutesId { get; private set; }
    public double FuelSpent { get; private set; }

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