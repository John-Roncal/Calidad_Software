using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        #region singleton
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        ///inserta
        public void InsertarCliente(entCliente cli)
        {
            datCliente.Instancia.InsertarCliente(cli);
        }

        ///deshabilitar
        public void DeshabilitarCliente(entCliente cli)
        {
            datCliente.Instancia.DeshabilitarClie(cli);
        }
        //condicion
        /*public Boolean ExisteNombreCategoria(string NomCategoria)
        {
            return datCategoria.Instancia.ExisteNombreCategoria(NomCategoria);
        }*/

        public void EditarCliente(entCliente cli)
        {
            datCliente.Instancia.EditarCliente(cli);
        }
        #endregion metodos

    }
}
