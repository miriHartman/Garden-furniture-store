using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class buyController : ControllerBase
    {
        
        IBll_Services.IBll_buy<DTO_Common.classes.Buy> bll;
        public buyController(IBll_Services.IBll_buy<DTO_Common.classes.Buy> bll1)
        {
            this.bll = bll1;
        }
        [HttpPost]
        public async Task<DTO_Common.classes.Buy> addBuy(DTO_Common.classes.ToSend sendObj)
        {
            //שולח לפונקציה בBLL שמוסיפה קניה
            //(כדי שימתין לערך שהוחזר אליו מהשרת (או לביצוע AWAIT לכן כתבתי תמיד ASYNC כלל הפונקציות מוגדרות   
            return await bll.addBuy(sendObj);
        }
        [HttpGet("Id")]
        public async Task<int> confirm(int Id)
        {
            return await bll.confirm(Id);
        }

    }

}
