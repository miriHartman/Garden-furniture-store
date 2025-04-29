using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal_Repository.classes

{
    public class Buy_Detailes
    {

       
        public int Id { get; set; }
        
        public int BuyId { get; set; }
        public int ProductId { get; set; }    
        public int Amount { get; set; }
        public virtual Buy buy { get; set; }
        public virtual Product product { get; set; }
    }
}
