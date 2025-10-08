using ProjectTurAgency.Entity;

namespace ProjectTurAgency.Repositories;

public interface ITourRepository
{
    IEnumerable<Tour> ReadTours();

    Tour ReadTourById(int id);

    void CreateTour(Tour tour);
    void UpdateTour(Tour tour);
    void DeleteTour(int id);
}
