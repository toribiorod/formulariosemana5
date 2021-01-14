using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Entities;

namespace CourseManagment.Domain.Entities
{
    
    public class Cliente : Persona
    {
        #region "Propiedades"

        private List<Cliente> clientes;
        public string Cuenta { get; set; }

        #endregion


        #region "Metodos
        public Cliente() {

            this.clientes = new List<Cliente>();
        
        }
        /// <summary>
        /// Agregar Cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void agregarClientes(Cliente cliente) {
            this.clientes.Add(cliente);
        
        }
        /// <summary>
        /// Eliminar Cliente
        /// </summary>
        /// <param name="cuenta">Número de cuenta</param>
        public void eliminarCliente(string cuenta) {
            var cue = this.clientes.Find(cl => this.Cuenta == cuenta);
            this.clientes.Remove(cue);
        }
        /*public Cliente obtenerClientes(string cuenta) {
            return this.clientes.Find(cl => this.Cuenta == cuenta);
        }*/
        /// <summary>
        /// Obtener Clientes pasando como párametro el numero de cuenta
        /// </summary>
        /// <param name="cuenta"> Número de cuenta</param>
        /// <returns></returns>
        public List<Cliente> obtenterClientes(string cuenta) {
            return this.clientes.FindAll(cl => this.Cuenta == cuenta);
        }
        /// <summary>
        /// Obtener todos los clientes
        /// </summary>
        /// <returns></returns>
        public List<Cliente> obtenerClientes() {
            return this.clientes;
        }
        #endregion
    }
}
