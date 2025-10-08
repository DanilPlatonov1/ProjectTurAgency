using ProjectTurAgency.Entity;

namespace ProjectTurAgency.Repositories;

public interface IRouteRepository
{
    IEnumerable<Route> ReadRoutes();

    Route ReadRouteById(int id);

    void CreateRoute(Route route);
    void UpdateRoute(Route route);
    void DeleteRoute(int id);
}
