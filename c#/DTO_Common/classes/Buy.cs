using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DTO_Common.classes
{
    public  class Buy
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateOfBuy { get; set; }
        public int AmountPay { get; set; }
        public string UserName { get; set; }
        public bool IsPay { get; set; }
        public string? Remark { get; set; }


    }
}
