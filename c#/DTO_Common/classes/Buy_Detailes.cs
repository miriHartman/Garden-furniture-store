using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DTO_Common.classes
{
    public  class Buy_Detailes
    {

       
        public int Id { get; set; }
        
        public int BuyId { get; set; }
       
        public int ProductId { get; set; }   
        public string ProductName { get; set; }
        public int Amount { get; set; }
        
    }
}
