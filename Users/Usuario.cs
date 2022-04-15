using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLoja.Users
{
    class Usuario
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public double Money { get; set; }
        public bool administrador { get; private set; }

        public Usuario(string name, string password)
        {
            Name = name;
            Password = password;
            Money = 100;
        }
        public Usuario(string name, string password, double money)
        {
            Name = name;
            Password = password;
            Money = money;
        }
        public Usuario(string name, string password, double money, bool admin)
        {
            Name = name;
            Password = password;
            Money = money;
            administrador = admin;
        }
    }
}
