using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SINU.UserModel
{
    public class User
    {

        public int UserId { get; set; }

        public string UserLastName { get; set; }
        public string UserFirstName { get; set; }
        public string UserAccountName { get; set; }
        public string UserPassWord { get; set; }

        public string UserEmail { get; set; }


    }
}
