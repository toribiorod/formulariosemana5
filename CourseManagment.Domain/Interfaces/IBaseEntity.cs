using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.BL
{
    interface IBaseEntity<IEntity> where IEntity : class
    {
        void guardar(IEntity ientity);
        void actualizart(IEntity ientity);
        void eliminar(IEntity ientity);

        IEntity obtenerIntety(int Id);

        List<IEntity> obtenerRegistro();


    }
}
