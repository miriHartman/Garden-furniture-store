using Dal_Repository.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class func_buydetails:IDallRepository.IDal_bydetails<DTO_Common.classes.Buy_Detailes>
    {
        //הוספת פרטי קניה במסד
       public async Task<int> addBuyDet(int buyId, List<DTO_Common.classes.Basket> baskets)
        {
            gardenContext gc= new gardenContext();
            //שליחה להוספת פרטי קניה את קוד הקניה שנוצר בהוספת קניה 
            //וכן את כל המוצרים הקנויים
            var buyDetailsMic = converts.To_Microsoft_Classes.toBuyDetList(buyId, baskets);
           //מעבר על כל מור מוזמן כדי לטפל בנתונים במסד שקשורים אליו
            foreach(var bdm in buyDetailsMic)
            {
                //גישה למוצרים ששמורים במסד עבור כל מוצר מהקניה שלי 
                
              var p= await gc.products.FirstOrDefaultAsync(p=>p.Id==bdm.ProductId);
                if (p != null)
                {
                    //אם קיים
                    //הפחתה של הכמות שהזמנתי מהכמות שכעת קיימת למוצר זה במסד
                    p.Amount-=bdm.Amount;
                }
               
                //הוספה במסד בטבלת פרטי קניה
                gc.buys_detailes.Add(bdm);
            }
            int isOk =await gc.SaveChangesAsync();
            return isOk;
            // החזרה של ערך מספרי האם ההוספה הצליחה או לא
        }

    }
}
