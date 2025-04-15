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
    public class logProvincia
    {
        #region singleton
        private static readonly logProvincia _instancia = new logProvincia();
        //privado para evitar la instanciación directa
        public static logProvincia Instancia
        {
            get
            {
                return logProvincia._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entProvincia> ListarProvincia()
        {
            return datProvincia.Instancia.ListarProvincia();
        }

        ///inserta
        public void InsertaProvincia(entProvincia prov)
        {
            datProvincia.Instancia.InsertarProvincia(prov);
        }

        public void EditarProvincia(entProvincia pro)
        {
            datProvincia.Instancia.EditarProvincia(pro);
        }

        ///deshabilitar
        public void DeshabilitarProvincia(entProvincia prov)
        {
            datProvincia.Instancia.DeshabilitarProv(prov);
        }
        //condicion
        /*public Boolean ExisteNombreCategoria(string NomCategoria)
        {
            return datCategoria.Instancia.ExisteNombreCategoria(NomCategoria);
        }*/

        public DataTable CargarProvincia()
        {
            return datProvincia.Instancia.CargarProvincia();
        }
        #endregion metodos
    }
}
