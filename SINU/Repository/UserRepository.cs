using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SINU.Data.UserContext;
using SINU.Repository;
using SINU.UserModel;

namespace SINU.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

      public  UserRepository(UserContext context) {

            _context = context;
        
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;


        }

        public User GetUserByEmail(string email){


            return _context.Users.FirstOrDefault(u => u.Email == email);
        }


    }
}
