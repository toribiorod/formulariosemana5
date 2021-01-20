using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Excepcions
{
    public class EmpleadoException: Exception
    {
        public EmpleadoException(string message) : base(message) { 
        }
    }
}
