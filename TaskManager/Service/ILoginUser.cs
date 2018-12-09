using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Service
{
    interface ILoginUser
    {
        bool FindUser(string UserName);
        bool Autorization(string UserName, string PassWord);
        bool SaveUser(string UserName, string PassWord);
        bool CreateUser(string UserName, string PassWord);
    }
}
