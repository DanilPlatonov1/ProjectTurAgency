using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface IRouteRepository
{
    IEnumerable<Route> ReadRoutes();

    Route ReadRouteById(int id);

    void CreateRoute(Route route);
    void UpdateRoute(Route route);
    void DeleteRoute(int id);
}
