using ProjectTurAgency.Entity;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Dapper;
using Npgsql;

namespace ProjectTurAgency.Repositories.Implementations
{
    internal class ContractRepository : IContractRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<ContractRepository> _logger;

        public ContractRepository(IConnectionString connectionString, ILogger<ContractRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public void CreateContract(Contract contract)
        {
            _logger.LogInformation("Добавление контракта");
            _logger.LogDebug("Контракт: {json}", JsonConvert.SerializeObject(contract));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryInsert = @"
                    INSERT INTO Contracts (ClientId, TourId, DiscountId, Date)
                    VALUES (@ClientId, @TourId, @DiscountId, @Date);";

                connection.Execute(queryInsert, new
                {
                    contract.ClientId,
                    contract.TourId,
                    contract.DiscountId,
                    contract.Date
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении контракта");
                throw;
            }
        }

        public void UpdateContract(Contract contract)
        {
            _logger.LogInformation("Редактирование контракта");
            _logger.LogDebug("Контракт: {json}", JsonConvert.SerializeObject(contract));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryUpdate = @"
                    UPDATE Contracts
                    SET ClientId = @ClientId,
                        TourId = @TourId,
                        DiscountId = @DiscountId,
                        Date = @Date
                    WHERE Id = @Id;";

                connection.Execute(queryUpdate, new
                {
                    contract.Id,
                    contract.ClientId,
                    contract.TourId,
                    contract.DiscountId,
                    contract.Date
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при редактировании контракта");
                throw;
            }
        }

        public void DeleteContract(int id)
        {
            _logger.LogInformation("Удаление контракта");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryDelete = "DELETE FROM Contracts WHERE Id = @id;";
                connection.Execute(queryDelete, new { id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении контракта");
                throw;
            }
        }

        public Contract ReadContractById(int id)
        {
            _logger.LogInformation("Получение контракта по идентификатору");
            _logger.LogDebug("Id: {id}", id);

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var querySelect = "SELECT * FROM Contracts WHERE Id = @id;";
                var contract = connection.QueryFirstOrDefault<Contract>(querySelect, new { id });

                _logger.LogDebug("Найденный контракт: {json}", JsonConvert.SerializeObject(contract));
                return contract!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при поиске контракта");
                throw;
            }
        }

        public IEnumerable<Contract> ReadContracts()
        {
            _logger.LogInformation("Получение всех контрактов");

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var querySelect = "SELECT * FROM Contracts;";
                var contracts = connection.Query<Contract>(querySelect);

                _logger.LogDebug("Полученные контракты: {json}", JsonConvert.SerializeObject(contracts));
                return contracts;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при чтении контрактов");
                throw;
            }
        }
    }
}
