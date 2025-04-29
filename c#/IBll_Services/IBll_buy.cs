using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
    public interface IBll_buy<T>
    {
        
        Task<T> addBuy(DTO_Common.classes.ToSend B);
        Task<int> confirm(int Id);
    }
}
