using CourseManagment.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using CourseManagment.Domain.Interfaces;

namespace CourseManagment.Domain.BL
{
    public class ClienteBL : BaseBL<Cliente>, ICliente
    {
        private List<Cliente> clientes;

        public ClienteBL() {
            this.clientes = new List<Cliente>();
        }

        public Cliente ObtenerClientePorCuenta(string cuenta)
        {
            return base.Entities.SingleOrDefault(cliente => cliente.Cuenta == cuenta);
        }

        public Cliente ObtenerEntity(int Id)
        {
            return base.Entities.Find(cliente => cliente.clienteID == Id);
        }
        public override void guardar(Cliente entity)
        {
            entity.clienteID = base.Entities.Count == 0 ? 1 : base.Entities.Max(cliente => cliente.clienteID) + 1;
            base.guardar(entity);
        }


        /*   public void actualizart(Cliente ientity)
           {
               throw new System.NotImplementedException();
           }

           public void eliminar(Cliente ientity)
           {
               this.clientes.Remove(ientity);
           }
           /// <summary>
           /// 
           /// </summary>
           /// <param name="ientity">Class</param>
           public void guardar(Cliente ientity)
           {
               ientity.clienteID = this.clientes.Count == 0 ? 1 : this.clientes.Max(clientes => clientes.clienteID) + 1;
               this.clientes.Add(ientity);
           }

           public List<Cliente> obtenerEntity()
           {
              return this.clientes;
           }

           public Cliente obtenerIntety(int Id)
           {
               return this.clientes.Find(cli=>cli.clienteID==Id);
           }

              public List<Cliente> obtenerRegistro()
           {
               return this.clientes;
           }*/
    }
}
