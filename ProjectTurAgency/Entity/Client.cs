using ProjectTurAgency.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity;
public class Client
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public ClientSex ClientSex { get; private set; }
    public string Phone { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;


    public static Client CreateEntity(int id, string fullName, ClientSex clientSex, string phone, string email)
    {
        return new Client
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            ClientSex = clientSex,
            Phone = phone ?? string.Empty,
            Email = email ?? string.Empty
        };
    }
}
