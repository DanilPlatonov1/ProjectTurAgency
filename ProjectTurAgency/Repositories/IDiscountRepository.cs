using ProjectTurAgency.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTurAgency.Repositories;

public interface IDiscountRepository
{
    IEnumerable<Discount> ReadDiscounts();

    Discount ReadDiscountById(int id);

    void CreateDiscount(Discount discount);
    void UpdateDiscount(Discount discount);
    void DeleteDiscount(int id);
}
