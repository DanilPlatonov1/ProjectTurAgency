using ProjectTurAgency.Entity.Enums;
using ProjectTurAgency.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Dapper;
using Npgsql;

namespace ProjectTurAgency.Repositories.Implementations;

internal class ClientRepository : IClientRepository
{
    private readonly IConnectionString _connectionString;
    private readonly ILogger<ClientRepository> _logger;

    public ClientRepository(IConnectionString connectionString, ILogger<ClientRepository> logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    public void CreateClient(Client client)
    {
        _logger.LogInformation("Добавление клиента");
        _logger.LogDebug("Клиент: {json}", JsonConvert.SerializeObject(client));

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryInsert = @"
                    INSERT INTO Clients (FullName, ClientSex, Phone, Email)
                    VALUES (@FullName, @ClientSex, @Phone, @Email);";

            connection.Execute(queryInsert, new
            {
                client.FullName,
                ClientSex = (int)client.ClientSex,
                client.Phone,
                client.Email
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении клиента");
            throw;
        }
    }

    public void UpdateClient(Client client)
    {
        _logger.LogInformation("Редактирование клиента");
        _logger.LogDebug("Клиент: {json}", JsonConvert.SerializeObject(client));

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryUpdate = @"
                    UPDATE Clients
                    SET FullName = @FullName,
                        ClientSex = @ClientSex,
                        Phone = @Phone,
                        Email = @Email
                    WHERE Id = @Id;";

            connection.Execute(queryUpdate, new
            {
                client.Id,
                client.FullName,
                ClientSex = (int)client.ClientSex,
                client.Phone,
                client.Email
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании клиента");
            throw;
        }
    }

    public void DeleteClient(int id)
    {
        _logger.LogInformation("Удаление клиента");
        _logger.LogDebug("Id: {id}", id);

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var queryDelete = "DELETE FROM Clients WHERE Id = @id;";
            connection.Execute(queryDelete, new { id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении клиента");
            throw;
        }
    }

    public Client ReadClientById(int id)
    {
        _logger.LogInformation("Получение клиента по идентификатору");
        _logger.LogDebug("Id: {id}", id);

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Clients WHERE Id = @id;";
            var client = connection.QueryFirstOrDefault<Client>(querySelect, new { id });
            _logger.LogDebug("Найденный клиент: {json}", JsonConvert.SerializeObject(client));
            return client!;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске клиента");
            throw;
        }
    }

    public IEnumerable<Client> ReadClients()
    {
        _logger.LogInformation("Получение всех клиентов");

        try
        {
            using var connection = new NpgsqlConnection(_connectionString.ConnectionString);
            var querySelect = "SELECT * FROM Clients;";
            var clients = connection.Query<Client>(querySelect);
            _logger.LogDebug("Полученные клиенты: {json}", JsonConvert.SerializeObject(clients));
            return clients;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении клиентов");
            throw;
        }
    }
}