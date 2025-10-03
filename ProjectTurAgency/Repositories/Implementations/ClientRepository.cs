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

namespace ProjectTurAgency.Repositories.Implementations;

public class ClientRepository : IClientRepository
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
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(client));

        try
        {
            using var connection = new SqlConnection(_connectionString.ConnectionString);
            var queryInsert = @" INSERT INTO Animals (AnimalSpecies, AnimalNickName, Age, Weight) VALUES (@AnimalSpecies, @AnimalNickName, @Age, @Weight)";
            connection.Execute(queryInsert, client);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteClient(int id) { }

    public Client ReadClientById(int id) => Client.CreateEntity(0, string.Empty, ClientSex.None, string.Empty, string.Empty);

    public IEnumerable<Client> ReadClients() => [];

    public void UpdateClient(Client client) { }
}
