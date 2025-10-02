using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity;

public class TourCompilation
{
    public int Id { get; private set; }
    public int TourId { get; private set; }
    public DateTime CompilationDate { get; private set; }

    public IEnumerable<TourRouteElement> TourRoutes { get; private set; } = [];

    public static TourCompilation CreateOperation(int id, int tourId, IEnumerable<TourRouteElement> tourRoutes)
    {
        return new TourCompilation
        {
            Id = id,
            TourId = tourId,
            CompilationDate = DateTime.Now,
            TourRoutes = tourRoutes
        };
    }
}