using CourseManagment.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagment.Domain.BL
{
    public class EmpleadoBL : IBaseEntity<Empleado>
    {

        private List<Empleado> empleados;
        public EmpleadoBL() {

            this.empleados = new List<Empleado>();
        }

        public void actualizart(Empleado ientity)
        {
            throw new System.NotImplementedException();
        }

        public void eliminar(Empleado ientity)
        {
            this.empleados.Remove(ientity);
        }

        public void guardar(Empleado ientity)
        {
            ientity.Codigo = this.empleados.Count == 0 ? 1 : this.empleados.Max(profesor => profesor.Codigo) + 1;

            this.empleados.Add(ientity);
        }

        public Empleado obtenerIntety(int Id)
        {
            return this.empleados.Find(code=>code.Codigo==Id);
        }

        public List<Empleado> obtenerRegistro()
        {
            return this.empleados;
        }
    }
}
