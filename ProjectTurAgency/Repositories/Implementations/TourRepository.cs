using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class TourRepository : ITourRepository
{
    public void CreateTour(Tour tour) { }

    public void DeleteTour(int id) { }

    public Tour ReadTourById(int id) => Tour.CreateEntity(0, string.Empty, 0, 0);

    public IEnumerable<Tour> ReadTours() => [];

    public void UpdateTour(Tour tour) { }
}
