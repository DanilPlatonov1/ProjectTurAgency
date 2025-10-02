using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity;

public class Route
{
    public int Id { get; private set; }
    public string StartPoint { get; private set; } = string.Empty;
    public string EndPoint { get; private set; } = string.Empty;
    public int DurationDays { get; private set; }

    public static Route CreateEntity(int id, string startPoint, string endPoint, int durationDays)
    {
        return new Route
        {
            Id = id,
            StartPoint = startPoint ?? string.Empty,
            EndPoint = endPoint ?? string.Empty,
            DurationDays = durationDays
        };
    }
}
