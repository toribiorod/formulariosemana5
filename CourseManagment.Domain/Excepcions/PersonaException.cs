using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Excepcions
{
    public class PersonaException: Exception
    {
        public PersonaException(string message) : base(message) {
        
        }
    }
}
