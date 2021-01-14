using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entities
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Rut { get; set; }
    }
}
