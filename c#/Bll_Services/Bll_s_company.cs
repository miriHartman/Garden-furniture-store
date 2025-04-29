using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class Bll_s_company:IBll_Services.IBll_company<DTO_Common.classes.Company>
    {
        IDallRepository.IDal_company<DTO_Common.classes.Company> c;
        public Bll_s_company(IDallRepository.IDal_company<DTO_Common.classes.Company> c1)
        {
            this.c = c1;
        }
        //companies
        public async Task<List<DTO_Common.classes.Company>> allCompanies()
        {
            var all = await c.allCompanies();
            return all;
        }
    }
}
