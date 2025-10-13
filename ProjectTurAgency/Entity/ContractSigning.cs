namespace ProjectTurAgency.Entity;

public class ContractSigning
{
    public int Id { get; private set; }

    public int ClientId { get; private set; }
    public int TourId { get; private set; }
    public int? DiscountId { get; private set; }

    public DateTime SigningDate { get; private set; }

    public static ContractSigning CreateOperation(int id, int clientId, int tourId, int? discountId, double discountPercent = 0)
    {
        return new ContractSigning
        {
            Id = id,
            ClientId = clientId,
            TourId = tourId,
            DiscountId = discountId,
            SigningDate = DateTime.Now,
        };
    }
}
