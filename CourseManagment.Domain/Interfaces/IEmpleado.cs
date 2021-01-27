using CourseManagment.Domain.Entities;

namespace CourseManagment.Domain.Interfaces
{
    public interface IEmpleado
    {
        Empleado ObtenerEntity(int Id);
    }
}
