using CourseManagment.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagment.Domain.BL
{
    public class ClienteBL : IBaseEntity<Cliente>
    {
        private List<Cliente> clientes;

        public ClienteBL() {
            this.clientes = new List<Cliente>();
        }

        public void actualizart(Cliente ientity)
        {
            throw new System.NotImplementedException();
        }

        public void eliminar(Cliente ientity)
        {
            this.clientes.Remove(ientity);
        }

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
        }
    }
}
