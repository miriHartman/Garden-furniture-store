using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Buy_detailsController : ControllerBase
    {
        IBll_Services.IBll_buydetails<DTO_Common.classes.Buy_Detailes> bll;
        public Buy_detailsController(IBll_Services.IBll_buydetails<DTO_Common.classes.Buy_Detailes> bll1)
        {
            this.bll = bll1;
        }

    }
}
