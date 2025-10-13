namespace ProjectTurAgency.Entity;

public class ContractSigning
{
    public int Id { get; private set; }

    public int ContractId { get; private set; }

    public DateTime SigningDate { get; private set; }

    public static ContractSigning CreateOperation(int id, int contractId)
    {
        return new ContractSigning
        {
            Id = id,
            ContractId = contractId,
            SigningDate = DateTime.Now,
        };
    }
}
