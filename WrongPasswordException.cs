using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_KazanovAlexandr
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException() : base ("Wrong password!") { }
        public WrongPasswordException(string message) : base(message) { }
    }
}
