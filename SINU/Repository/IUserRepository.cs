using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.UserModel;

namespace SINU.Repository { 
    public interface IUserRepository
    {
         User GetUserByEmail(string email);

        User Create(User user);



    }
}
