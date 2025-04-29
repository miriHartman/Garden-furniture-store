using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDallRepository
{
    public interface IDal_company<T>
    {
       Task<List<T>> allCompanies();
    }
}
