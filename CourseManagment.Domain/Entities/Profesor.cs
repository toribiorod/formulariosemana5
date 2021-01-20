using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Excepcions;

namespace CourseManagment.Domain.Entities
{

    public class Profesor: Persona
    {
        #region "Propiedades"

        public int ProfesorID { get; set; }
        private List<Profesor> profesores;
        private string _codigo;
        private string _carrera;
        public string _departamento;
        public string Codigo {
            get { return this._codigo; }
            set {
                if (string.IsNullOrEmpty(value)) {

                    throw new ProfesorException("El código no puede estar vacío");
                }
                _codigo= value;
            
            }
        
        }       
        public string Carrera { 
        get 
            { 
                return _carrera; 
            }
            set 
                                {
                //Validar que no sea nulo//

                if (string.IsNullOrEmpty(value))
                {
                    throw new ProfesorException($"El campo carrera es requerido..");
                }
                    //Validar que no sea nulo//
                if (value.Length > 10)
                {
                    throw new ProfesorException($"El campo carrera no puede ser mayor a 10 carácteres..");
                }

                _carrera = value;
                }
            }

        public string Departamento
        {

            get
            {
                return this._departamento;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ProfesorException("El departamento no puede estar vacío");
                }
                _departamento = value;
            }

        }
        #endregion

        #region "Metodos"
        public Profesor() {
            this.profesores = new List<Profesor>();
        }

        public void agregarProfesores(Profesor profe) {
            this.profesores.Add(profe);
        }
        public List<Profesor> obtenerProfesores() {
            return this.profesores;
        }

        #endregion
    }
}
