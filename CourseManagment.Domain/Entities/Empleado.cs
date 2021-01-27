using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Excepcions;

namespace CourseManagment.Domain.Entities
{
    public class Empleado : Persona
    {
        #region "Propiedades"
        
        private List<Empleado> empleados;
        private decimal _sueldo;
        private int _codigo;
        public decimal Sueldo {

            get {
                return this._sueldo;
            }

            set {
                if (decimal.TryParse(_sueldo.ToString(), out decimal outParamName))
                {
                    _sueldo = value;
                }
                else {
                    throw new EmpleadoException("Error no es decimal");
                }              

            }
        
        
        }
        public int Codigo { 
            get { 
                return this._codigo; 
            
            } 
            set {
                int myInt;
                bool isNumerical = int.TryParse(_sueldo.ToString(), out myInt);
                if (isNumerical)
                {
                    _codigo = value;
                }
                else {
                    throw new EmpleadoException("Error , el código debe ser número");
                }

                
            } 
        
        }

        #endregion

        #region "Metodos"

        
        public Empleado() {
            this.empleados = new List<Empleado>();          
        }
        /* /// <summary>
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
         }*/
        #endregion

    }
}
