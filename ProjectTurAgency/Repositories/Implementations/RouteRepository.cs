using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class RouteRepository : IRouteRepository
{
    public void CreateRoute(Route route) { }

    public void DeleteRoute(int id) { }

    public Route ReadRouteById(int id) => Route.CreateEntity(0, string.Empty, string.Empty, 0);

    public IEnumerable<Route> ReadRoutes() => [];

    public void UpdateRoute(Route route) { }
}
