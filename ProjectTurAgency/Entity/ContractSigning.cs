using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity;

public class ContractSigning
{
    public int Id { get; private set; }

    public int ClientId { get; private set; }
    public int TourId { get; private set; }
    public int? DiscountId { get; private set; }

    public DateTime SigningDate { get; private set; }
    public double FinalPrice { get; private set; }

    public static ContractSigning CreateOperation(int id, int clientId, int tourId, int? discountId, double tourPrice, double discountPercent = 0)
    {
        double finalPrice = tourPrice;
        if (discountId.HasValue)
        {
            finalPrice = tourPrice - (tourPrice * discountPercent / 100);
        }

        return new ContractSigning
        {
            Id = id,
            ClientId = clientId,
            TourId = tourId,
            DiscountId = discountId,
            SigningDate = DateTime.Now,
            FinalPrice = finalPrice
        };
    }
}
