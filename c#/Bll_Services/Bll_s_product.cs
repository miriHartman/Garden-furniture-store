using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class Bll_s_product:IBll_Services.IBll_product<DTO_Common.classes.Product>
    {
        IDallRepository.IDal_product<DTO_Common.classes.Product> p;
        public Bll_s_product(IDallRepository.IDal_product<DTO_Common.classes.Product> p1)
        {
            this.p = p1;
        }
        public async Task<List<DTO_Common.classes.Product>> allProducts()
        {
            var all = await p.allProducts();
            return all;
        }
        public async Task<List<DTO_Common.classes.Product>> filterProduct(int? pid, int? companyId,int? price)
        {
            if (price!=null)
            {
             //var filter=p.productByCategory(pid)
            }
            return await p.filterProduct(pid,companyId,price);
            
        }

    }
}
