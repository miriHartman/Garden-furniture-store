using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class Bll_s_buy : IBll_Services.IBll_buy<DTO_Common.classes.Buy>
    {
        //הזרקה
        IDallRepository.IDal_buy<DTO_Common.classes.Buy> buyDto;
        IDallRepository.IDal_user<DTO_Common.classes.User> userDto;
        IDallRepository.IDal_bydetails<DTO_Common.classes.Buy_Detailes> buyDetailesDto;
            
        //בנאי המחלקה
        public Bll_s_buy(IDallRepository.IDal_buy<DTO_Common.classes.Buy> b1, IDallRepository.IDal_user<DTO_Common.classes.User> u, IDallRepository.IDal_bydetails<DTO_Common.classes.Buy_Detailes> buyDetailesDto )
        {
            this.buyDto = b1;
            this.userDto = u;
            this.buyDetailesDto= buyDetailesDto;
        }

        //פונקצית הוספת קניה טיפול בכל הערכים בטרם שמירתו במסד

        //dall -לאחר מכן שליחה ליצירת קניה ופרטי קניה-כמובן שליחה ל
        public async Task<DTO_Common.classes.Buy> addBuy(DTO_Common.classes.ToSend tosend)
        {


            string remark = "";
            int Present = 0;
            DateTime today = DateTime.Today;
            //שליפה של הלקוח הנוכחי- חייב להיות רשום הבדיקה והפניה להרשמה מתבצעת כבר בלקוח
            DTO_Common.classes.User myUser = await userDto.getUserById(tosend.EmailUser);
            //בדיקה האם יש ללקוח יום הולדת בחודש הנוכחי
            if (myUser.Bearthday.Month == today.Month)
            {
                //אם כן הוזלת הקניה עפ חישוב מקומי בעתיד אולי נפתח מחלקת הנחה
                Present += 25;
                tosend.TotalPriceToSend = tosend.TotalPriceToSend * (100 - Present) / 100;
                remark += "מזל טוב ליום הולדתך!!  ";
            }
            //אם הימים סמוכים לשבת ג"כ הערה ללקוח כמו ביום ההולדת
            if (today.DayOfWeek == DayOfWeek.Friday || today.DayOfWeek == DayOfWeek.Thursday)
            {
                remark += "\nשבת שלום:)";
            }
           
            //לאחר כל השינויים  DALשליחה ל 
            //ראשית יצירת קניה
            DTO_Common.classes.Buy buyToReturn= await buyDto.addBuy(myUser.Id, today, tosend.TotalPriceToSend, myUser.Name, remark);
           // שליחה ליצירת פרטי קניה  DAL רק שכרגע הקניה לא שולמה
           //שליחה ליצירת פרטי קניה עם קוד הקניה שנוצר לי בהוספת קניה במסד
            int isOk=await buyDetailesDto.addBuyDet(buyToReturn.Id, tosend.Baskets);


            // מוחזר אובייקט המכיל את השדות אותם הלקוח צריך לקבל
            return buyToReturn;

        }
        public async Task<int> confirm(int Id)
        {
            return await buyDto.confirm(Id);
        }

    }
}
