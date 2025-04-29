using Dal_Repository.classes;
using DTO_Common.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class func_buy:IDallRepository.IDal_buy<DTO_Common.classes.Buy>
    {
        // מקבלת את כל הערכים האמורים להתקבל עבור יצירת אובייקט מסוג מייקרוסופט
  //מקבלת מה BLL
        public async Task<DTO_Common.classes.Buy> addBuy(int UserId, DateTime DateOfBuy, int TotalPriceToSend,string userName, string? remark)
        {
            gardenContext gc = new gardenContext();
            // -שם נוצר לי אובייקט קניה לסוג microsoft שליחה להמרה 
            var buy_m = converts.To_Microsoft_Classes.toBuyMic(UserId, DateOfBuy, TotalPriceToSend, remark);
           //מה שמוחזר מההמרה - נשמר לי במסד
            gc.buys.Add(buy_m);
            int isOk=await gc.SaveChangesAsync();
            if(isOk>0)//אם מצליח מחזיר את האובייקט אך בהמרתו לסוג אותו הלקוח מבין כלומר למחלקה אותה אני יצרתי
            return  converts.To_DTO.toBuyDto(buy_m,userName);
            return null;
        }

        public async Task<int> confirm(int id)
        {
            //סימון הקניה כ-שולם
            gardenContext gc = new gardenContext();
            //שחיפת הקניה שלי
            var myBuy=await gc.buys.FirstOrDefaultAsync(b => b.Id == id);
            if(myBuy != null)
                //סימון שולם
                //מלכתכילה נוצר לי בבנאי השדה "האם שולם" כשלילי
                myBuy.IsPay = true;
            //שמירת השינויים
            return await gc.SaveChangesAsync();
                

        }

    }

}
