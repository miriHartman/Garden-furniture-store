using Dal_Repository.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class func_company:IDallRepository.IDal_company<DTO_Common.classes.Company>
    {
        gardenContext g = new gardenContext();
        //all companies
        public async Task<List<DTO_Common.classes.Company>> allCompanies()
        {
            var companys = await g.companies.ToListAsync();
            return Dal_Repository.converts.To_DTO.toListCompanyDto(companys);
        }
    }
}
