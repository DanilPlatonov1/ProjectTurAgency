using ProjectTurAgency.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Dapper;
using Npgsql;
using System.Text;

namespace ProjectTurAgency.Repositories.Implementations
{
    internal class TourCompilationRepository : ITourCompilationRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<TourCompilationRepository> _logger;

        public TourCompilationRepository(IConnectionString connectionString, ILogger<TourCompilationRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public void CreateTourCompilation(TourCompilation tourCompilation)
        {
            _logger.LogInformation("Добавление составления тура");
            _logger.LogDebug("TourCompilation: {json}", JsonConvert.SerializeObject(tourCompilation));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                connection.Open();

                using var transaction = connection.BeginTransaction();

                try
                {
                    // Вставляем основную запись
                    var queryInsertCompilation = @"
                        INSERT INTO TourCompilation (TourId, CompilationDate)
                        VALUES (@TourId, @CompilationDate)
                        RETURNING Id;";

                    int compilationId = connection.ExecuteScalar<int>(
                        queryInsertCompilation,
                        new
                        {
                            tourCompilation.TourId,
                            CompilationDate = tourCompilation.CompilationDate
                        },
                        transaction
                    );

                    // Вставляем связанные маршруты
                    var queryInsertRoutes = @"
                        INSERT INTO TourRouteElement (RouteId, DayOrder)
                        VALUES (@RouteId, @DayOrder);";

                    foreach (var route in tourCompilation.TourRoutes)
                    {
                        connection.Execute(queryInsertRoutes, new
                        {
                            route.RouteId,
                            route.DayOrder
                        }, transaction);
                    }

                    transaction.Commit();
                    _logger.LogInformation("Составление тура успешно добавлено (Id={id})", compilationId);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    _logger.LogError(ex, "Ошибка при добавлении составления тура (откат транзакции)");
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении составления тура");
                throw;
            }
        }

        public void DeleteTourCompilation(int id)
        {
            _logger.LogInformation("Удаление составления тура");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                connection.Open();

                using var transaction = connection.BeginTransaction();

                try
                {
                    var queryDeleteRoutes = @"
                        DELETE FROM TourRouteElement
                        WHERE RouteId IN (
                            SELECT Id FROM Route WHERE Id IN (
                                SELECT TourId FROM TourCompilation WHERE Id = @id
                            )
                        );";

                    connection.Execute(queryDeleteRoutes, new { id }, transaction);

                    var queryDeleteCompilation = "DELETE FROM TourCompilation WHERE Id = @id;";
                    connection.Execute(queryDeleteCompilation, new { id }, transaction);

                    transaction.Commit();
                    _logger.LogInformation("Составление тура удалено (Id={id})", id);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    _logger.LogError(ex, "Ошибка при удалении составления тура (откат транзакции)");
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении составления тура");
                throw;
            }
        }

        public IEnumerable<TourCompilation> ReadTourCompilations(DateTime? dateFrom = null, DateTime? dateTo = null, int? tourId = null)
        {
            _logger.LogInformation("Получение списка составлений туров");

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);

                var querySelect = new StringBuilder(@"
                    SELECT * FROM TourCompilation
                    WHERE 1=1");

                if (dateFrom.HasValue)
                    querySelect.Append(" AND CompilationDate >= @dateFrom");

                if (dateTo.HasValue)
                    querySelect.Append(" AND CompilationDate <= @dateTo");

                if (tourId.HasValue)
                    querySelect.Append(" AND TourId = @tourId");

                querySelect.Append(" ORDER BY CompilationDate DESC;");

                var compilations = connection.Query<TourCompilation>(
                    querySelect.ToString(),
                    new { dateFrom, dateTo, tourId }
                );

                _logger.LogDebug("Полученные составления туров: {json}", JsonConvert.SerializeObject(compilations));
                return compilations;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении составлений туров");
                throw;
            }
        }
    }
}
