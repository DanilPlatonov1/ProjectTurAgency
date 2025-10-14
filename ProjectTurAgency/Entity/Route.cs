using ProjectTurAgency.Entity.Enums;

public class Route
{
    public int Id { get; private set; }
    public string StartPoint { get; private set; } = string.Empty;
    public string EndPoint { get; private set; } = string.Empty;
    public int DurationDays { get; private set; }
    public RouteAttractions Attractions { get; private set; } = RouteAttractions.None;

    public static Route CreateEntity(int id, string startPoint, string endPoint, int durationDays, RouteAttractions attractions = RouteAttractions.None)
    {
        return new Route
        {
            Id = id,
            StartPoint = startPoint ?? string.Empty,
            EndPoint = endPoint ?? string.Empty,
            DurationDays = durationDays,
            Attractions = attractions
        };
    }
}