using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        IBll_Services.IBll_product<DTO_Common.classes.Product> bll;
        public productController(IBll_Services.IBll_product<DTO_Common.classes.Product> bll1)
        {
            this.bll = bll1;
        }
        [HttpGet]
        public async Task<List<DTO_Common.classes.Product>> allProducts()
        {
            return await bll.allProducts();
        }
        [HttpGet("filter")]
        public async Task<List<DTO_Common.classes.Product>> productByCategory([FromQuery] int? categoryId, [FromQuery] int? companyId, [FromQuery] int? price) { 
        return await bll.filterProduct(categoryId,companyId, price);
        }
    }
}
