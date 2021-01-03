using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t13
{
    public class MyStringFormatException : Exception
    {
        public string Message { get; }

        public MyStringFormatException(string message) : base(message)
        {
            Message = message;
        }
    }
}
