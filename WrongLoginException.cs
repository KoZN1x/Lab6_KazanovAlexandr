using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_KazanovAlexandr
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException() : base("Wrong login!") { }
        public WrongLoginException(string message) : base (message) { }
    }
}
