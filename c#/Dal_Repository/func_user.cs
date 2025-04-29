using Dal_Repository.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class func_user:IDallRepository.IDal_user<DTO_Common.classes.User>
    {
        public  async Task<int> addUser(DTO_Common.classes.User user_dto)
        {
            gardenContext gc =new gardenContext();
            gc.users.Add(Dal_Repository.converts.To_Microsoft_Classes.toUserMic(user_dto));
            int x=gc.SaveChanges();
            return x;
        }
        public async Task<bool>  Login(string Email)
        {
            gardenContext gc = new gardenContext();
            var us =await gc.users.FirstOrDefaultAsync(u => u.Email == Email);
            if (us != null)
            {
                return true;
            }
            return false;
        }
        public async Task<DTO_Common.classes.User> getUserById(string Email)
        {
            gardenContext gc = new gardenContext();
            var user1 =await gc.users.FirstOrDefaultAsync(y=>y.Email==Email);
      
                return  converts.To_DTO.toUserDto(user1);
            }

        }


    }

