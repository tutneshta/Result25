using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.BLL.Exception
{
    class NullIdException : System.Exception
    {
        public NullIdException()
        {
        }

        public NullIdException(string message) : base(message)
        {
        }

        public NullIdException(string message, System.Exception ex) : base(message)
        {
        }
    }
}