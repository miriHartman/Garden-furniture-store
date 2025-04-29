using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class Bll_s_buydetails:IBll_Services.IBll_buydetails<DTO_Common.classes.Buy_Detailes>
    {
        IDallRepository.IDal_bydetails<DTO_Common.classes.Buy_Detailes> b;
        public Bll_s_buydetails(IDallRepository.IDal_bydetails<DTO_Common.classes.Buy_Detailes> b1) { 
        this.b = b1;
        }
    }
}
