using Dal_Repository.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Dal_Repository
{
    public class func_product:IDallRepository.IDal_product<DTO_Common.classes.Product>
    {
        gardenContext g = new gardenContext();

        ////all products
        public async Task<List<DTO_Common.classes.Product>> allProducts()
        {
            var products = await g.products.Include("Category").Include("Company").ToListAsync();
            return Dal_Repository.converts.To_DTO.toListProductDto(products);
        }
        public async Task<List<DTO_Common.classes.Product>> filterProduct(int? categoryId, int? companyId,int? price)
        {   
            var after =await g.products.Include("Category").Include("Company").Where(o => o.CategoryId == categoryId || categoryId==0|| !categoryId.HasValue).Where(h=>h.CompanyId==companyId || companyId==0 || !companyId.HasValue) .Where(o=>  !price.HasValue|| o.Price < price || o.Price == price || price==0
            ).ToListAsync();
            
            return  Dal_Repository.converts.To_DTO.toListProductDto(after);



        }
    }
}
