namespace ProjectFuelAccounting.Entities;

public class Refuel
{
    public int Id { get; private set; }
    public int CarsId { get; private set; }
    public int DriversId { get; private set; }
    public DateTime RefuelDate { get; private set; }
    public double FuelAmount { get; private set; }

    public static Refuel CreateOperation(int id, int carsId, int driversId, double fuelAmount)
    {
        return new Refuel
        {
            Id = id,
            CarsId = carsId,
            DriversId = driversId,
            RefuelDate = DateTime.Now,
            FuelAmount = fuelAmount
        };
    }
}