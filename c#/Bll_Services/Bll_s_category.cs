using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class Bll_s_category:IBll_Services.IBll_category<DTO_Common.classes.Category>
    {
        IDallRepository.Idal_category<DTO_Common.classes.Category> c;
        public Bll_s_category(IDallRepository.Idal_category<DTO_Common.classes.Category> c1)
        {
            this.c = c1;
        }

        //categories
        public async Task<List<DTO_Common.classes.Category>> allCategories()
        {
            var all = await c.allCategories();
            return all;
        }
    }
}
