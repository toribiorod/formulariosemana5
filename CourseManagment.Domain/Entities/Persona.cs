using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Excepcions;

namespace CourseManagment.Domain.Entities
{
    public abstract class Persona
    {
        private string _nombre { get; set; }
        private string _apellido { get; set; }
        private string _direccion { get; set; }
        private string _rut { get; set; }

        public string Nombre { 
            
            get {
                return this._nombre;
            } set {

                if (string.IsNullOrEmpty(value)) {
                    throw new PersonaException("No puede estar vacío");
                }                
               _nombre =value ; 
            } 
        }

        public string Apellido {         
        get
            {
                return this._apellido;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new PersonaException("No puede estar vacío");
                }
                    _apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new PersonaException("No puede estar vacío");
                }
                _direccion = value;
            }
        }
        public string Rut
        {
            get
            {
                return this._rut;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new PersonaException("No puede estar vacío");
                }
                _rut = value;
            }
        }


    }
}
