using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class ContractRepository : IContractRepository
{
    public void CreateContract(Contract contract) { }

    public void DeleteContract(int id) { }

    public Contract ReadContractById(int id) => Contract.CreateEntity(0, 0, 0, null, DateTime.Now);

    public IEnumerable<Contract> ReadContracts() => [];

    public void UpdateContract(Contract contract) { }
}
