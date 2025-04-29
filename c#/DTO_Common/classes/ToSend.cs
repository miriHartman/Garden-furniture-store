using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common.classes
{
    //מחלקה מסוג המוחזר ללקוח לאחר הוספת קניה 
    public class ToSend
    {
        public string EmailUser { get; set; }
        public int TotalPriceToSend { get; set; }
        public  List<Basket> Baskets { get; set; }
    }
}
