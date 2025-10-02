using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface IContractRepository
{
    IEnumerable<Contract> ReadContracts();

    Contract ReadContractById(int id);

    void CreateContract(Contract contract);
    void UpdateContract(Contract contract);
    void DeleteContract(int id);
}
