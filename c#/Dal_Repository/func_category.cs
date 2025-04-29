using Dal_Repository.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class func_category:IDallRepository.Idal_category<DTO_Common.classes.Category>
    {
        gardenContext g = new gardenContext();

        
        
        //all categories
        public async Task<List<DTO_Common.classes.Category>> allCategories()
        {
            var categories=await g.categories.ToListAsync();
            return Dal_Repository.converts.To_DTO.toListCategoryDto(categories);
        }


    }
}
