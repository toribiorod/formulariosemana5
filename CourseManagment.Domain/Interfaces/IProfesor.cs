using CourseManagment.Domain.Entities;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Interfaces
{
    public interface IProfesor: IBusquedaDepartamentoCarrera<Profesor>
    {
        Profesor ObtenerProfesorPorCodigo(string codigo);
        Profesor ObtenerEntity(string codigo);
    }
}
