using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public class UserModel : ModelBase
    {
        public string login { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }

        public UserModel()
        {
            login = "";
            password = "";
            nickname = "";
            email = "";
        }
    }
}
