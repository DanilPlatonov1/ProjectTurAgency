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
    internal class ContractSigningRepository : IContractSigningRepository
    {
        private readonly IConnectionString _connectionString;
        private readonly ILogger<ContractSigningRepository> _logger;

        public ContractSigningRepository(IConnectionString connectionString, ILogger<ContractSigningRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public void CreateContractSigning(ContractSigning contractSigning)
        {
            _logger.LogInformation("Создание записи о подписании контракта");
            _logger.LogDebug("Данные: {json}", JsonConvert.SerializeObject(contractSigning));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryInsert = @"
                    INSERT INTO ContractSignings (ContractId, SigningDate)
                    VALUES (@ContractId, @SigningDate);";

                connection.Execute(queryInsert, new
                {
                    contractSigning.ContractId,
                    contractSigning.SigningDate,
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при создании записи о подписании контракта");
                throw;
            }
        }

        public IEnumerable<ContractSigning> ReadContractSignings(
            DateTime? dateFrom = null,
            DateTime? dateTo = null,
            int? contractId = null)
        {
            _logger.LogInformation("Получение записей о подписании контрактов с фильтрацией");
            _logger.LogDebug("Параметры фильтра: {json}", JsonConvert.SerializeObject(new { dateFrom, dateTo, contractId }));

            try
            {
                using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
                var queryBuilder = new StringBuilder(@"
                    SELECT * FROM ContractSignings
                    WHERE 1=1");

                var parameters = new DynamicParameters();

                if (dateFrom.HasValue)
                {
                    queryBuilder.Append(" AND SigningDate >= @dateFrom");
                    parameters.Add("@dateFrom", dateFrom.Value);
                }

                if (dateTo.HasValue)
                {
                    queryBuilder.Append(" AND SigningDate <= @dateTo");
                    parameters.Add("@dateTo", dateTo.Value);
                }

                if (contractId.HasValue)
                {
                    queryBuilder.Append(" AND ContractId = @contractId");
                    parameters.Add("@contractId", contractId.Value);
                }

                queryBuilder.Append(" ORDER BY SigningDate DESC;");

                var signings = connection.Query<ContractSigning>(queryBuilder.ToString(), parameters);
                _logger.LogDebug("Найденные записи: {json}", JsonConvert.SerializeObject(signings));
                return signings;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении списка подписаний контрактов");
                throw;
            }
        }
    }
}
