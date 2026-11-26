using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFuelAccounting.Entities;

public class Route
{
    [Key]
    public int Id { get; internal set; }

    [Required]
    [Column("Name")]
    public string Name { get; internal set; } = string.Empty;

    public double Distance { get; internal set; }

    public Route() { }

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