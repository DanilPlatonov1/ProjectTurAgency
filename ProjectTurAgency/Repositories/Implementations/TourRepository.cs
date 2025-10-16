using Dapper;
using Microsoft.Extensions.Logging;
using Npgsql;
using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTurAgency.Repositories.Implementations
{
    internal class TourRepository : ITourRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<TourRepository> _logger;

        public TourRepository(IConnectionString connectionString, ILogger<TourRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public void CreateTour(Tour tour, IEnumerable<int> routeIds)
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                // 1️⃣ Создаем тур
                var tourId = connection.ExecuteScalar<int>(
                    "INSERT INTO Tours (Name, Price) VALUES (@Name, @Price) RETURNING Id;",
                    new { tour.Name, tour.Price }, transaction
                );

                // 2️⃣ Добавляем связи с маршрутами
                const string insertLink = "INSERT INTO TourRoutes (TourId, RouteId) VALUES (@TourId, @RouteId);";
                foreach (var routeId in routeIds)
                    connection.Execute(insertLink, new { TourId = tourId, RouteId = routeId }, transaction);

                transaction.Commit();
                _logger.LogInformation("Тур создан с Id={tourId}", tourId);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logger.LogError(ex, "Ошибка при создании тура");
                throw;
            }
        }

        public void UpdateTour(Tour tour, IEnumerable<int> routeIds)
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                // 1️⃣ Обновляем сам тур
                const string updateTour = "UPDATE Tours SET Name=@Name, Price=@Price WHERE Id=@Id;";
                connection.Execute(updateTour, new { tour.Id, tour.Name, tour.Price }, transaction);

                // 2️⃣ Удаляем старые связи
                const string deleteLinks = "DELETE FROM TourRoutes WHERE TourId=@TourId;";
                connection.Execute(deleteLinks, new { TourId = tour.Id }, transaction);

                // 3️⃣ Добавляем новые связи
                const string insertLink = "INSERT INTO TourRoutes (TourId, RouteId) VALUES (@TourId, @RouteId);";
                foreach (var routeId in routeIds)
                    connection.Execute(insertLink, new { TourId = tour.Id, RouteId = routeId }, transaction);

                transaction.Commit();
                _logger.LogInformation("Тур (Id={tourId}) обновлен", tour.Id);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logger.LogError(ex, "Ошибка при обновлении тура");
                throw;
            }
        }

        public void DeleteTour(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            connection.Execute("DELETE FROM Tours WHERE Id=@Id;", new { Id = id });
        }

        public Tour ReadTourById(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            return connection.QuerySingleOrDefault<Tour>("SELECT Id, Name, Price FROM Tours WHERE Id=@Id;", new { Id = id });
        }

        public IEnumerable<Tour> ReadTours()
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            return connection.Query<Tour>("SELECT Id, Name, Price FROM Tours ORDER BY Id;");
        }
    }
}
