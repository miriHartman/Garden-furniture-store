using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common.classes
{
    public class Basket
    {// המוצר וכמותו כמו שמתקבל מהלקוח בהזמנתו

        public int PId { get; set; }
        public string PName { get; set; }
         public int PQuty { get; set; }    
        public int PPrice { get; set; }
        //סהכ מחיר - חישוב שמימילא מתבצע בלקוח אזי הוא מתקבל לכאן וממחיר זה מפחית את הנחות יום ההולדת
            public int PTotalPrice { get; set; }
        public string? PPicture { get; set; } 
        public string? PDec { get; set; }


    }
}
