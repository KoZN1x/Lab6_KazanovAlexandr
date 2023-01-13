using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_KazanovAlexandr
{
    internal class Authorization
    {
        private string _login;
        private string _password;
 
        public Authorization(string login, string password, string confirmPassword)
        {
            if (AuthorizationCheck(login, password, confirmPassword))
            {
                _login = login;
                _password = password;
            }
        }

        public static bool AuthorizationCheck(string login, string password, string confirmPassword)
        {
            if (login.Length > 20 || login.Contains(' '))
            {
                throw new WrongLoginException(); 
            }
            if (password != confirmPassword)
            {
                throw new WrongPasswordException("Wrong password confirmation!");
            }
            return true;
        }
    }
}
