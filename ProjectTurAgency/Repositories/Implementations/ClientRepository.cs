using ProjectTurAgency.Entity.Enums;
using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class ClientRepository : IClientRepository
{
    public void CreateClient(Client client) { }

    public void DeleteClient(int id) { }

    public Client ReadClientById(int id) => Client.CreateEntity(0, string.Empty, ClientSex.None, string.Empty, string.Empty);

    public IEnumerable<Client> ReadClients() => [];

    public void UpdateClient(Client client) { }
}
