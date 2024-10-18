using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_webstore
{
    public class User
    {
        public string Name { get; set; } //просто имя, может быть одинаковым
        public string Login { get; } //уникальный, как id
        public string Password { get; }
        public bool IsLoggedIn { get; set; }
        public List<IProduct> Cart { get; set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
            IsLoggedIn = false;
            Cart = new List<IProduct>();
        }

        static public string GetHash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
