using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.converts
{
    public class To_Microsoft_Classes
    {

        //public static Dal_Repository.classes.Company toCompanyMicr(DTO_Common.classes.Company comp_dto)
        //{
        //    Dal_Repository.classes.Company comp_dal=new Dal_Repository.classes.Company();
        //    comp_dal.Id = comp_dto.Id;
        //    comp_dal.Name = comp_dto.Name;
        //    return comp_dal;
        //}

        public static Dal_Repository.classes.User toUserMic(DTO_Common.classes.User user_dto)
        {
                     Dal_Repository.classes.User us_dal = new Dal_Repository.classes.User();
                     us_dal.Email = user_dto.Email;
                     us_dal.Bearthday = user_dto.Bearthday;
                     us_dal.Id = user_dto.Id;
                     us_dal.Phone = user_dto.Phone;
                     us_dal.Name = user_dto.Name;
            return us_dal;

    }
        public static Dal_Repository.classes.Buy toBuyMic(int UserId, DateTime DateOfBuy, int TotalPriceToSend, string? remark)
        {// המרה למיקוסופט של קניה
            Dal_Repository.classes.Buy buy_mic= new Dal_Repository.classes.Buy();
            buy_mic.UserId = UserId;
            buy_mic.DateOfBuy = DateOfBuy;
            buy_mic.Remark = remark;
            buy_mic.AmountPay = TotalPriceToSend;
//בעת המרת קניה למיקרוסופט מלכתכילה השדה לא שולם
            buy_mic.IsPay = false;

            return buy_mic;


        }
        public static Dal_Repository.classes.Buy_Detailes toBuyDet(int buyId, DTO_Common.classes.Basket basket)
        {//המרה למיקרוסופט פרטי קניה
           Dal_Repository.classes.Buy_Detailes BuyDeMic = new Dal_Repository.classes.Buy_Detailes();
            BuyDeMic.BuyId = buyId;
            BuyDeMic.ProductId = basket.PId;
            BuyDeMic.Amount = basket.PQuty;
            
            return BuyDeMic;
        }

        public static List<Dal_Repository.classes.Buy_Detailes> toBuyDetList(int buyId,List<DTO_Common.classes.Basket> baskets)
        {//המרה של רשימה!! של פרטי קניה למיקרוסופט
            List<Dal_Repository.classes.Buy_Detailes> listBuyDeMic = new List<Dal_Repository.classes.Buy_Detailes>();
            foreach(var  basket in baskets)
            {
                listBuyDeMic.Add(toBuyDet(buyId, basket));
            }
            return  listBuyDeMic;

        }
}
}
