namespace ProjectFuelAccounting.Entities;

public class Route
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public double Distance { get; private set; }

    public static Route CreateEntity(int id, string name, double distance)
    {
        return new Route
        {
            Id = id,
            Name = name ?? string.Empty,
            Distance = distance
        };
    }
}