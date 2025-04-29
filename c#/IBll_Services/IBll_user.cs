using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
    public interface IBll_user<T>
    {
        Task<int> addUser(T user_dto);
        Task<bool> login(string Email);


    }
}
