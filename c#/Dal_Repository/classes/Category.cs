using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal_Repository.classes
{
    public class Category
    {
        public  int  Id { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; } = new List<Product>();
    }
}
