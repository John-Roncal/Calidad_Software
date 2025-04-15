using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class datProvincia
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProvincia _instancia = new datProvincia();
        //privado para evitar la instanciación directa
        public static datProvincia Instancia
        {
            get
            {
                return datProvincia._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////listado
        public List<entProvincia> ListarProvincia()
        {
            SqlCommand cmd = null;
            List<entProvincia> lista = new List<entProvincia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProvincia prov = new entProvincia();

                    prov.Codigo = dr["Codigo"].ToString();
                    prov.NombreProv = dr["Nombre"].ToString();
                    prov.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(prov);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        /////////////////////////Insertar
        public Boolean InsertarProvincia(entProvincia prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsetarProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", prov.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", prov.NombreProv);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarProvincia(entProvincia pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", pro.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", pro.NombreProv);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCategoria
        public Boolean DeshabilitarProv(entProvincia prov)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", prov.Codigo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public DataTable CargarProvincia()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarProvincia", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion metodos
    }
}
