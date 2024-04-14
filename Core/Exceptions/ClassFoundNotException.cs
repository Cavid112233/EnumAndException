using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Exceptions
{
    public class NotFoundClassException: Exception
    {
        public NotFoundClassException(string message) : base(message) 
        {
            message = message;
        }
    }
}
