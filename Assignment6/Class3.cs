using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class BankExeception : ApplicationException
    {
        public BankExeception(string message) : base(message)
        {
        }
    }
}
