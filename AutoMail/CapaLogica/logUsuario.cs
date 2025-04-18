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
    public class logUsuario
    {
        #region singleton
        private static entUsuario usuarioLogueado;
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            try
            {
                bool credencialesValidas = datUsuario.Instancia.ValidarCredenciales(nombreUsuario, contraseña);
                if (credencialesValidas)
                {
                    usuarioLogueado = datUsuario.Instancia.ObtenerUsuarioPorNombre(nombreUsuario);
                }
                return credencialesValidas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public entUsuario ObtenerUsuarioLogueado()
        {
            return usuarioLogueado;
        }

        #endregion metodos

    }
}
