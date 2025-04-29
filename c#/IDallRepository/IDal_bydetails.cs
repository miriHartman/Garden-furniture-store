using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDallRepository
{
    public interface IDal_bydetails<T>
    {
        Task<int> addBuyDet(int buyId, List<DTO_Common.classes.Basket> baskets);
    }
}
