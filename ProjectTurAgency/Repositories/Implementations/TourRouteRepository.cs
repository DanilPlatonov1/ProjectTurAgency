using Dapper;
using Microsoft.Extensions.Logging;
using Npgsql;
using ProjectTurAgency.Entity;

namespace ProjectTurAgency.Repositories.Implementations
{
    internal class TourRouteRepository : ITourRouteRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<TourRouteRepository> _logger;

        public TourRouteRepository(IConnectionString connectionString, ILogger<TourRouteRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public IEnumerable<TourRoute> ReadAll()
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            const string sql = "SELECT TourId, RouteId FROM TourRoutes;";
            return connection.Query<TourRoute>(sql);
        }

        public IEnumerable<TourRoute> ReadByTourId(int tourId)
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            const string sql = "SELECT TourId, RouteId FROM TourRoutes WHERE TourId = @tourId;";
            return connection.Query<TourRoute>(sql, new { tourId });
        }

        public void AddTourRoute(TourRoute tourRoute)
        {
            _logger.LogInformation("Добавление связи тур-маршрут: {tourId} - {routeId}", tourRoute.TourId, tourRoute.RouteId);

            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            const string sql = "INSERT INTO TourRoutes (TourId, RouteId) VALUES (@TourId, @RouteId);";
            connection.Execute(sql, tourRoute);
        }

        public void DeleteTourRoute(int tourId, int routeId)
        {
            _logger.LogInformation("Удаление связи тур-маршрут: {tourId} - {routeId}", tourId, routeId);

            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            const string sql = "DELETE FROM TourRoutes WHERE TourId = @tourId AND RouteId = @routeId;";
            connection.Execute(sql, new { tourId, routeId });
        }

        public void DeleteAllByTourId(int tourId)
        {
            _logger.LogInformation("Удаление всех связей для тура {tourId}", tourId);

            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            const string sql = "DELETE FROM TourRoutes WHERE TourId = @tourId;";
            connection.Execute(sql, new { tourId });
        }
    }
}
