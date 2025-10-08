using ProjectTurAgency.Entity;

namespace ProjectTurAgency.Repositories;

public interface IContractRepository
{
    IEnumerable<Contract> ReadContracts();

    Contract ReadContractById(int id);

    void CreateContract(Contract contract);
    void UpdateContract(Contract contract);
    void DeleteContract(int id);
}
