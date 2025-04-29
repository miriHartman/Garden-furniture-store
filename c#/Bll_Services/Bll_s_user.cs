using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class Bll_s_user:IBll_Services.IBll_user<DTO_Common.classes.User>
    {
        IDallRepository.IDal_user<DTO_Common.classes.User> u;
        public Bll_s_user(IDallRepository.IDal_user<DTO_Common.classes.User> u1) {
        this.u = u1;
        }
        public async Task<int> addUser(DTO_Common.classes.User user_dto)
        {
            return await  u.addUser(user_dto);
        }
        public async Task<bool> login(string Email)
        {
            return await u.Login(Email);
        }


    }

}
