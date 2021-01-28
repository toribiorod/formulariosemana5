using System;
using System.Collections.Generic;
using CourseManagment.Domain.Entities;

namespace CourseManagment.Domain.BL
{
    public class BaseBL<TEntity> where TEntity : class
    {
        private List<TEntity> entities;

        public BaseBL() {
            this.entities = new List<TEntity>();
        }
        public List<TEntity> Entities {
             get { return this.entities; } 
        }
        public virtual void guardar(TEntity entity) {
            this.entities.Add(entity);
        }
        public virtual void eliminar(TEntity entity) {
            this.entities.Remove(entity);
        }
        public virtual List<TEntity> obtenerRegistro() {
            return this.entities;
        
        }
    }
}
