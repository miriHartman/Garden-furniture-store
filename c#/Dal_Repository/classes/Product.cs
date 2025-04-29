using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal_Repository.classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public int Price { get; set; }
      
        public int Amount { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }
      public virtual Company Company { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Buy_Detailes> Buy_Detailes { get; set; } = new List<Buy_Detailes>();
    }
}
