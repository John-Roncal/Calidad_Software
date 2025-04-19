using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;


namespace CapaDatos
{
    public class datUsuario
    {

        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datUsuario _instancia = new datUsuario();
        //privado para evitar la instanciación directa
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion singleton


        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            bool esValido = false;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spValidarCredenciales", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Hashear la contraseña con SHA-256
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] claveHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                    cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                    cmd.Parameters.Add("@Contraseña", SqlDbType.VarBinary, 64).Value = claveHash;
                }

                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                esValido = count > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                    cmd.Connection.Close();
            }

            return esValido;
        }

        public entUsuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            entUsuario usuario = null;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerUsuarioPorNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuario = new entUsuario();
                    usuario.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                    usuario.RolID = Convert.ToInt32(dr["RolID"]);
                    usuario.Usuario = dr["Usuario"].ToString();
                    usuario.Clave = (byte[])dr["Clave"];
                    usuario.EstadoUsuario = Convert.ToBoolean(dr["EstadoUsuario"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                    cmd.Connection.Close();
            }
            return usuario;
        }

        public int ObtenerRolIDPorNombre(string nombreUsuario)
        {
            int rolID = 0;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spObtenerRolIDPorNombre", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);

                cn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    rolID = Convert.ToInt32(result);
                }
            }
            return rolID;
        }
    }
}
