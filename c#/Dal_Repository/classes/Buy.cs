using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal_Repository.classes
{
    public class Buy
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateOfBuy { get; set; }
        public int AmountPay { get; set; }
        public bool IsPay { get; set; }

        public string? Remark { get; set; }

        public virtual User User { get; set; } 
        public virtual ICollection<Buy_Detailes> Buy_Detailes { get; set; } = new List<Buy_Detailes>();
        
    }

    }

