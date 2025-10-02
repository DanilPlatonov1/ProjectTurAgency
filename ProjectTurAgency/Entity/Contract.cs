using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Entity;

public class Contract
{
    public int Id { get; private set; }
    public int ClientId { get; private set; }
    public int TourId { get; private set; }
    public int? DiscountId { get; private set; }
    public DateTime Date { get; private set; }

    public static Contract CreateEntity(int id, int clientId, int tourId, int? discountId, DateTime date)
    {
        return new Contract
        {
            Id = id,
            ClientId = clientId,
            TourId = tourId,
            DiscountId = discountId,
            Date = date
        };
    }
}
