using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity
{
    public class TourRoute
    {
        public int TourId { get; private set; }
        public int RouteId { get; private set; }

        public Tour? Tour { get; private set; }
        public Route? Route { get; private set; }

        public static TourRoute CreateEntity(int tourId, int routeId)
        {
            return new TourRoute
            {
                TourId = tourId,
                RouteId = routeId
            };
        }
    }
}

