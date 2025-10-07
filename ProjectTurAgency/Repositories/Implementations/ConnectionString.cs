namespace ProjectTurAgency.Repositories.Implementations;

internal class ConnectionString : IConnectionString
{
    string IConnectionString.ConnectionString => "Host=localhost;Port=5432;Database=TurAgency;Username=postgres;Password=psql12";
}
