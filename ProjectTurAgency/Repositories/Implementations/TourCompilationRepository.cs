using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class TourCompilationRepository : ITourCompilationRepository
{
    public void CreateTourCompilation(TourCompilation tourCompilation) { }

    public void DeleteTourCompilation(int id) { }

    public IEnumerable<TourCompilation> ReadTourCompilations(DateTime? dateFrom = null, DateTime? dateTo = null, int? tourId = null)
    {
        return [];
    }
}
