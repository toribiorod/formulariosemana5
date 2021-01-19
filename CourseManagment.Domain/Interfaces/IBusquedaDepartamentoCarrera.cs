using CourseManagment.Domain.Entities;
using System.Collections.Generic;
namespace CourseManagment.Domain.Interfaces
{
    public interface IBusquedaDepartamentoCarrera<TEntity> where TEntity:class
    {
        List<TEntity> obtenerProfesoresPorDepartamento(string departamento);
        List<TEntity> obtenerProfesoresPorCarrera(string carrera);
    }
}