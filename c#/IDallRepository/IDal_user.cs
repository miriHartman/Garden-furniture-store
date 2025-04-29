using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDallRepository
{
    public interface IDal_user<T>
    {
        Task<int> addUser(T user);
        Task<bool> Login(string Email);
        Task<T> getUserById(string Email);
    }
}
