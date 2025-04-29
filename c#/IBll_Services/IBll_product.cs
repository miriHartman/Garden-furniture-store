using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
    public interface IBll_product<T>
    {
        Task<List<T>> allProducts();
        Task<List<T>> filterProduct(int? categoryId, int? companyId,int? price);

    }
}
