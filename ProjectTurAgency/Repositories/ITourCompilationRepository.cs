using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface ITourCompilationRepository
{
    IEnumerable<TourCompilation> ReadTourCompilations(DateTime? dateFrom = null, DateTime? dateTo = null, int? tourId = null);
    void CreateTourCompilation(TourCompilation tourCompilation);
    void DeleteTourCompilation(int id);
}
