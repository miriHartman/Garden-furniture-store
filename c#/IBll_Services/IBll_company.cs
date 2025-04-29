using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
    public interface IBll_company<T>
    {
        Task<List<T>> allCompanies();
    }
}
