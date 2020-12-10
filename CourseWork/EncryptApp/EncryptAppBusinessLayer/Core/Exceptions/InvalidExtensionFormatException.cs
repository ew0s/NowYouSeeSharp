using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptAppBusinessLayer.Core.Exceptions
{
    public class InvalidExtensionFormatException : Exception
    {
        public InvalidExtensionFormatException(string message) : base("Application do not support this extension " +
                                                                      message)
        {

        }
    }
}
