using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TaskManager.Service
{
    class LoginUser:ILoginUser
    {
        SerializableDictionary<string, string> UserList;
        public LoginUser()
        {
            UserList = new SerializableDictionary<string, string>();
            XmlSerializer formatter = new XmlSerializer(typeof(SerializableDictionary<string, string>));
            using (System.IO.FileStream fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            {
                UserList = (SerializableDictionary<string, string>)formatter.Deserialize(fs);
            }
        }
        public bool CreateUser(string UserName, string PassWord)
        {
            try
            {
                UserList.Add(UserName, PassWord);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Autorization(string UserName, string PassWord)
        {
            if (UserList[UserName] == PassWord)
                return true;

            return false;
        }
        public bool FindUser(string UserName)
        {
            return UserList.ContainsKey(UserName);
        }
        public bool SaveUser(string UserName, string PassWord)
        {
            try
            {
                UserList.Add(UserName, PassWord);
            }
            catch
            {
                return false;
            }
            return true;
        }
        ~LoginUser()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(SerializableDictionary<string, string>));
            using (System.IO.FileStream fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs,UserList);
            }
        }
    }
}
