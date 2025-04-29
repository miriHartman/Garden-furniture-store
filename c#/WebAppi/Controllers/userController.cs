using Bll_Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        IBll_Services.IBll_user<DTO_Common.classes.User> bll;
        public userController(IBll_Services.IBll_user<DTO_Common.classes.User> bll1)
        {
            this.bll = bll1;
        }
        [HttpPost]
        public async Task<int> addUser(DTO_Common.classes.User user_dto)
        {
            return await bll.addUser(user_dto);
        }
        [HttpGet("/userEmail")]
        public async Task<bool> login(string userEmail)
        {
            return await bll.login(userEmail);
        }
    }
     
}
