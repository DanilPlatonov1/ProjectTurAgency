using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class ContractSigningRepository : IContractSigningRepository
{
    public void CreateContractSigning(ContractSigning contractSigning) { }

    public IEnumerable<ContractSigning> ReadContractSignings(DateTime? dateFrom = null, DateTime? dateTo = null, int? clientId = null, int? tourId = null)
    {
        return [];
    }
}
