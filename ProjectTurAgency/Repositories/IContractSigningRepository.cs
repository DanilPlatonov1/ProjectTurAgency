using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface IContractSigningRepository
{
    IEnumerable<ContractSigning> ReadContractSignings(DateTime? dateFrom = null, DateTime? dateTo = null, int? contractId = null);
    void CreateContractSigning(ContractSigning contractSigning);
}
