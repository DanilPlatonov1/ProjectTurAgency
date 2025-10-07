using ProjectTurAgency.Entity;
using Dapper;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void CreateTour(Tour tour)
        {
            _logger.LogInformation("Добавление тура");
            _logger.LogDebug("Tours: {json}", JsonConvert.SerializeObject(tour));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                connection.Open();

                var query = @"
                    INSERT INTO Tours (Name, Price, RouteId)
                    VALUES (@Name, @Price, @RouteId);";

                connection.Execute(query, new
                {
                    tour.Name,
                    tour.Price,
                    tour.RouteId
                });

                _logger.LogInformation("Тур успешно добавлен: {name}", tour.Name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении тура");
                throw;
            }
        }

        public void DeleteTour(int id)
        {
            _logger.LogInformation("Удаление тура");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                connection.Open();

                var query = "DELETE FROM Tours WHERE Id = @id;";
                connection.Execute(query, new { id });

                _logger.LogInformation("Тур успешно удалён (Id={id})", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении тура");
                throw;
            }
        }

        public Tour ReadTourById(int id)
        {
            _logger.LogInformation("Чтение тура по Id");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);

                var query = "SELECT Id, Name, Price, RouteId FROM Tours WHERE Id = @id;";
                var tour = connection.QuerySingleOrDefault<Tour>(query, new { id });

                if (tour == null)
                {
                    _logger.LogWarning("Тур с Id={id} не найден", id);
                    return Tour.CreateEntity(0, string.Empty, 0, 0);
                }

                return tour;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении тура по Id");
                throw;
            }
        }

        public IEnumerable<Tour> ReadTours()
        {
            _logger.LogInformation("Чтение списка туров");

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);

                var query = "SELECT Id, Name, Price, RouteId FROM Tours ORDER BY Id;";
                var tours = connection.Query<Tour>(query);

                _logger.LogDebug("Полученные туры: {json}", JsonConvert.SerializeObject(tours));
                return tours;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении туров");
                throw;
            }
        }

        public void UpdateTour(Tour tour)
        {
            _logger.LogInformation("Обновление данных тура");
            _logger.LogDebug("Tours: {json}", JsonConvert.SerializeObject(tour));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                connection.Open();

                var query = @"
                    UPDATE Tours
                    SET Name = @Name,
                        Price = @Price,
                        RouteId = @RouteId
                    WHERE Id = @Id;";

                connection.Execute(query, new
                {
                    tour.Id,
                    tour.Name,
                    tour.Price,
                    tour.RouteId
                });

                _logger.LogInformation("Тур (Id={id}) успешно обновлён", tour.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении тура");
                throw;
            }
        }
    }
}
