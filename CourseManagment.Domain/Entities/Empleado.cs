using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entities
{
    public class Empleado : Persona
    {
        #region "Propiedades"
        
        private List<Empleado> empleados;
        public decimal Sueldo { get; set; }
        public int Codigo { get; set; }

        #endregion

        #region "Metodos"

        
        public Empleado() {
            this.empleados = new List<Empleado>();          
        }
        /// <summary>
        /// Agregar un emeplado
        /// </summary>
        /// <param name="empleado"></param>
        public void agregarEmpleado(Empleado empleado) {
            this.empleados.Add(empleado);        
        }
        /// <summary>
        /// Eliminar un empleado
        /// </summary>
        /// <param name="codigo"></param>
        public void eliminarEmpleado(int codigo) {
            var epl = this.empleados.Find(ep => this.Codigo == codigo);
            this.empleados.Remove(epl);
        }
        /// <summary>
        /// Obtener todos los empleados
        /// </summary>
        /// <returns></returns>
        public List<Empleado> obtenerEmpleados() {

            return this.empleados;
        }
        #endregion

    }
}
