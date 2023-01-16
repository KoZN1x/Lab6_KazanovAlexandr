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

        private static bool AuthorizationCheck(string login, string password, string confirmPassword)
        {
            if (login.Length > 20 || login.Contains(' '))
            {
                throw new WrongLoginException(); 
            }
            if (password != confirmPassword || !IsPasswordCorrect(password))
            {
                throw new WrongPasswordException();
            }
            return true;
        }
        private static bool IsPasswordCorrect(string password)
        {
            bool isDigit = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    isDigit = true;
                    break;
                }
                else isDigit = false;
            }
            if (password.Length > 20 || password.Contains(' ') || !isDigit)
            {
                return false;
            }
            else return true;
        }
    }
}
