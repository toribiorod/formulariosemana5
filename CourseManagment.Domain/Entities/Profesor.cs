using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entities
{

    public class Profesor: Persona
    {
        #region "Propiedades"

        public int ProfesorID { get; set; }
        private List<Profesor> profesores;
        public string Codigo { get; set; }
        public string Carrera { get; set; }
        public string Departamento { get; set; }

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
