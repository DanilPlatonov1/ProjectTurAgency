using ProjectTurAgency.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Dapper;
using Npgsql;

namespace ProjectTurAgency.Repositories.Implementations
{
    internal class RouteRepository : IRouteRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<RouteRepository> _logger;

        public RouteRepository(IConnectionString connectionString, ILogger<RouteRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public void CreateRoute(Route route)
        {
            _logger.LogInformation("Добавление маршрута");
            _logger.LogDebug("Маршрут: {json}", JsonConvert.SerializeObject(route));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryInsert = @"
                    INSERT INTO Routes (StartPoint, EndPoint, DurationDays)
                    VALUES (@StartPoint, @EndPoint, @DurationDays);";

                connection.Execute(queryInsert, new
                {
                    route.StartPoint,
                    route.EndPoint,
                    route.DurationDays
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении маршрута");
                throw;
            }
        }

        public void UpdateRoute(Route route)
        {
            _logger.LogInformation("Редактирование маршрута");
            _logger.LogDebug("Маршрут: {json}", JsonConvert.SerializeObject(route));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryUpdate = @"
                    UPDATE Routes
                    SET StartPoint = @StartPoint,
                        EndPoint = @EndPoint,
                        DurationDays = @DurationDays
                    WHERE Id = @Id;";

                connection.Execute(queryUpdate, new
                {
                    route.Id,
                    route.StartPoint,
                    route.EndPoint,
                    route.DurationDays
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при редактировании маршрута");
                throw;
            }
        }

        public void DeleteRoute(int id)
        {
            _logger.LogInformation("Удаление маршрута");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryDelete = "DELETE FROM Routes WHERE Id = @id;";
                connection.Execute(queryDelete, new { id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении маршрута");
                throw;
            }
        }

        public Route ReadRouteById(int id)
        {
            _logger.LogInformation("Получение маршрута по Id");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var querySelect = "SELECT * FROM Routes WHERE Id = @id;";
                var route = connection.QueryFirstOrDefault<Route>(querySelect, new { id });

                _logger.LogDebug("Найденный маршрут: {json}", JsonConvert.SerializeObject(route));
                return route!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении маршрута");
                throw;
            }
        }

        public IEnumerable<Route> ReadRoutes()
        {
            _logger.LogInformation("Получение всех маршрутов");

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var querySelect = "SELECT * FROM Routes;";
                var routes = connection.Query<Route>(querySelect);

                _logger.LogDebug("Полученные маршруты: {json}", JsonConvert.SerializeObject(routes));
                return routes;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении маршрутов");
                throw;
            }
        }
    }
}
