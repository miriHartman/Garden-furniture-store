using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class bll_services
    {


        Dal_Repository.func_category bs = new Dal_Repository.func_category();

        
        //categories
        public async Task<List<DTO_Common.classes.Category>> allCategories()
        {
            var all = await bs.allCategories();
            return all;
        }
       

    }
}
