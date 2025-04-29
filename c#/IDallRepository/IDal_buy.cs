using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDallRepository
{
    public interface IDal_buy<T>
    {
        Task<T> addBuy(int userId, DateTime DateOfBuy, int AmountPay,string userName,  string? Remark);
        Task<int> confirm(int Id);
    }
}
