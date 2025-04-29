using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class companyController : ControllerBase
    {
        IBll_Services.IBll_company<DTO_Common.classes.Company> bll;
        public companyController(IBll_Services.IBll_company<DTO_Common.classes.Company> bll1)
        {
            this.bll = bll1;
        }
        [HttpGet]
        public async Task<List<DTO_Common.classes.Company>> allCompanies()
        {
            return await bll.allCompanies();
        }
    }
}
