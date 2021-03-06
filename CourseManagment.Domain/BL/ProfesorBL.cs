﻿using CourseManagment.Domain.Entities;
using CourseManagment.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagment.Domain.BL
{
    public class ProfesorBL : BaseBL<Profesor>, IProfesor
    {
        //private List<Profesor> profesors;
        /*public ProfesorBL() {

            this.profesors = new List<Profesor>();
        }*/

        public Profesor ObtenerEntity(string codigo)
        {
            return base.Entities.Find(profesor => profesor.Codigo == codigo);
        }
        public  Profesor  ObtenerProfesorPorCodigo(string codigo)
        {
            return base.Entities.Find(procode => procode.Codigo == codigo);
        }
        public override void guardar(Profesor entity)
        {
            entity.ProfesorID = this.Entities.Count == 0 ? 1 : this.Entities.Max(profesorId => profesorId.ProfesorID) + 1;
            base.guardar(entity);
        }

        public List<Profesor> obtenerProfesoresPorDepartamento(string departamento)
        {
            throw new System.NotImplementedException();
        }

        public List<Profesor> obtenerProfesoresPorCarrera(string carrera)
        {
            throw new System.NotImplementedException();
        }
        /* 
        public void actualizart(Profesor ientity)
        {
        throw new System.NotImplementedException();
        }

        public void eliminar(Profesor ientity)
        {
        this.profesors.Remove(ientity);
        }

        public void guardar(Profesor ientity)
        {
        ientity.ProfesorID = this.profesors.Count == 0 ? 1 : this.profesors.Max(profesorId => profesorId.ProfesorID)+1;
        this.profesors.Add(ientity);
        }

        public List<Profesor> obtenerRegistro()
        {
        return this.profesors;
        }

        public Profesor obtenerIntety(int Id)
        {
        return this.profesors.Find(profesorid=> profesorid.ProfesorID==Id);
        }

        public List<Profesor> obtenerProfesoresPorCarrera(string carrera)
        {
        return this.profesors.FindAll(profesorid => profesorid.Carrera == carrera); ;
        }

        public List<Profesor> obtenerProfesoresPorDepartamento(string departamento)
        {
        return this.profesors.FindAll(prodepar=>prodepar.Departamento==departamento);
        }

        public Profesor ObtenerProfesorPorCodigo(string codigo)
        {
        return this.profesors.Find(procode => procode.Codigo == codigo);
        }

        public List<Profesor> obtenerEntity()
        {
        throw new System.NotImplementedException();
        }*/
    }
}
