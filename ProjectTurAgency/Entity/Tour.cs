namespace ProjectTurAgency.Entity;

public class Tour
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public double Price { get; private set; }
    public int RouteId { get; private set; }

    public static Tour CreateEntity(int id, string name, double price, int routeId)
    {
        return new Tour
        {
            Id = id,
            Name = name ?? string.Empty,
            Price = price,
            RouteId = routeId
        };
    }
}
