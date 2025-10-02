using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories.Implementations;

internal class DiscountRepository : IDiscountRepository
{
    public void CreateDiscount(Discount discount) { }

    public void DeleteDiscount(int id) { }

    public Discount ReadDiscountById(int id) => Discount.CreateEntity(0, string.Empty, 0);

    public IEnumerable<Discount> ReadDiscounts() => [];

    public void UpdateDiscount(Discount discount) { }
}
