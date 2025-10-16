using ProjectTurAgency.Entity;

namespace ProjectTurAgency.Repositories
{
    public interface ITourRouteRepository
    {
        IEnumerable<TourRoute> ReadAll();

        IEnumerable<TourRoute> ReadByTourId(int tourId);

        void AddTourRoute(TourRoute tourRoute);

        void DeleteTourRoute(int tourId, int routeId);

        void DeleteAllByTourId(int tourId);
    }
}