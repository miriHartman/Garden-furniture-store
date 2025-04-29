using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {
        IBll_Services.IBll_category<DTO_Common.classes.Category> bll;
        public categoryController(IBll_Services.IBll_category<DTO_Common.classes.Category> bll1)
        {
            this.bll = bll1;
        }
        [HttpGet]
        public async Task<ActionResult<List<DTO_Common.classes.Category>>> allCategories()
        {
            return Ok(await bll.allCategories());
        }
    }
}
