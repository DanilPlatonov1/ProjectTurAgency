using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity;

public class TourRouteElement
{
    public int Id { get; private set; }
    public int RouteId { get; private set; }
    public int DayOrder { get; private set; }

    public static TourRouteElement CreateElement(int id, int routeId, int dayOrder)
    {
        return new TourRouteElement
        {
            Id = id,
            RouteId = routeId,
            DayOrder = dayOrder
        };
    }
}
