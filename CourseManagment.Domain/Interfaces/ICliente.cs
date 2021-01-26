using CourseManagment.Domain.Entities;

namespace CourseManagment.Domain.Interfaces
{
    public interface ICliente
    {
        Cliente ObtenerEntity(int Id);
        Cliente ObtenerClientePorCuenta(string cuenta);
    }
}
