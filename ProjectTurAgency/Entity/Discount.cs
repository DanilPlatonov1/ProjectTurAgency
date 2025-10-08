namespace ProjectTurAgency.Entity;

public class Discount
{
    public int Id { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public double Percent { get; private set; }

    public static Discount CreateEntity(int id, string description, double percent)
    {
        return new Discount
        {
            Id = id,
            Description = description ?? string.Empty,
            Percent = percent
        };
    }
}
