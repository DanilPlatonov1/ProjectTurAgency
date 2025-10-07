using ProjectTurAgency.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Dapper;
using Npgsql;

namespace ProjectTurAgency.Repositories.Implementations
{
    internal class DiscountRepository : IDiscountRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<DiscountRepository> _logger;

        public DiscountRepository(IConnectionString connectionString, ILogger<DiscountRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public void CreateDiscount(Discount discount)
        {
            _logger.LogInformation("Добавление скидки");
            _logger.LogDebug("Скидка: {json}", JsonConvert.SerializeObject(discount));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryInsert = @"
                    INSERT INTO Discounts (Description, Percent)
                    VALUES (@Description, @Percent);";

                connection.Execute(queryInsert, new
                {
                    discount.Description,
                    discount.Percent
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении скидки");
                throw;
            }
        }

        public void UpdateDiscount(Discount discount)
        {
            _logger.LogInformation("Редактирование скидки");
            _logger.LogDebug("Скидка: {json}", JsonConvert.SerializeObject(discount));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryUpdate = @"
                    UPDATE Discounts
                    SET Description = @Description,
                        Percent = @Percent
                    WHERE Id = @Id;";

                connection.Execute(queryUpdate, new
                {
                    discount.Id,
                    discount.Description,
                    discount.Percent
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при редактировании скидки");
                throw;
            }
        }

        public void DeleteDiscount(int id)
        {
            _logger.LogInformation("Удаление скидки");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryDelete = "DELETE FROM Discounts WHERE Id = @id;";
                connection.Execute(queryDelete, new { id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении скидки");
                throw;
            }
        }

        public Discount ReadDiscountById(int id)
        {
            _logger.LogInformation("Получение скидки по идентификатору");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var querySelect = "SELECT * FROM Discounts WHERE Id = @id;";
                var discount = connection.QueryFirstOrDefault<Discount>(querySelect, new { id });

                _logger.LogDebug("Найденная скидка: {json}", JsonConvert.SerializeObject(discount));
                return discount!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при поиске скидки");
                throw;
            }
        }

        public IEnumerable<Discount> ReadDiscounts()
        {
            _logger.LogInformation("Получение всех скидок");

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var querySelect = "SELECT * FROM Discounts;";
                var discounts = connection.Query<Discount>(querySelect);

                _logger.LogDebug("Полученные скидки: {json}", JsonConvert.SerializeObject(discounts));
                return discounts;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении скидок");
                throw;
            }
        }
    }
}
