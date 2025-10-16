using ProjectTurAgency.Entity;
using System.Collections.Generic;

namespace ProjectTurAgency.Repositories
{
    public interface ITourRepository
    {
        IEnumerable<Tour> ReadTours();

        Tour ReadTourById(int id);

        void CreateTour(Tour tour, IEnumerable<int> routeIds);

        void UpdateTour(Tour tour, IEnumerable<int> routeIds);

        void DeleteTour(int id);
    }
}