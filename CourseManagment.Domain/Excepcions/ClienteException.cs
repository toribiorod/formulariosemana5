using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Excepcions
{
    public class ClienteException: Exception
    {
        public ClienteException(string message) : base(message) { 
        
        }
    }
}
