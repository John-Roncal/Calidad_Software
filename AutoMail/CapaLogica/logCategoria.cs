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
    public class logCategoria
    {
        #region singleton
        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciación directa
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategorias();
        }

        ///inserta
        public void InsertaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.InsertarCategoria(Cat);
        }

        ///editar
        public void EditarCategoria(entCategoria cat)
        {
            datCategoria.Instancia.EditarCategoria(cat);
        }

        public DataTable CargarCategoria()
        {
            return datCategoria.Instancia.CargarCategoria();
        }

        ///deshabilitar
        public void DeshabilitarCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.DeshabilitarCategoria(Cat);
        }
        //condicion
        /*public Boolean ExisteNombreCategoria(string NomCategoria)
        {
            return datCategoria.Instancia.ExisteNombreCategoria(NomCategoria);
        }*/
        #endregion metodos
    }
}