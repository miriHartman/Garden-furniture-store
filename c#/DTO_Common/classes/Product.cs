using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common.classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public string nameCategory { get; set; }
        public int CompanyId { get; set; }
        public string nameCompany { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string? Picture { get; set; }

        public DateTime LastUpdate { get; set; }
        public string? Description { get; set; }


    }
}
