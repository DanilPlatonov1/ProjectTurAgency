namespace ProjectTurAgency.Repositories.Implementations;

internal class ConnectionString : IConnectionString
{
    string IConnectionString.ConnectionString => "Host=localhost;Port=5432;Database=TourAgency;Username=postgres;Password=psql12";
}
