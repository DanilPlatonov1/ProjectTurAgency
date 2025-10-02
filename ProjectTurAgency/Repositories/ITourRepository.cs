using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface ITourRepository
{
    IEnumerable<Tour> ReadTours();

    Tour ReadTourById(int id);

    void CreateTour(Tour tour);
    void UpdateTour(Tour tour);
    void DeleteTour(int id);
}
