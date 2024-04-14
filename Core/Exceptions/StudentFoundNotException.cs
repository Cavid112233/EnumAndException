using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Exceptions
{
    public class NotFoundStudentException : Exception
    {
        public NotFoundStudentException(string message) : base(message)
        {

        }
    }
}
