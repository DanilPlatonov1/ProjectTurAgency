using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface IClientRepository
{
    IEnumerable<Client> ReadClients();

    Client ReadClientById(int id);

    void CreateClient(Client client);
    void UpdateClient(Client client);
    void DeleteClient(int id);
}