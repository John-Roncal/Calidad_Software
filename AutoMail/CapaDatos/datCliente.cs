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
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos

        ////////////////////listado
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cl = new entCliente();
                    cl.Id = Convert.ToInt32(dr["ClienteId"]);
                    cl.Nombre = dr["ClienteNombre"].ToString();
                    cl.Mail = dr["Mail"].ToString();
                    cl.Web = dr["Web"].ToString();

                    // Mapeo de categoría
                    cl.categoria = new entCategoria();
                    cl.categoria.Id = Convert.ToInt32(dr["CategoriaId"]);
                    cl.categoria.Nombre = dr["CategoriaNombre"].ToString();

                    // Mapeo de provincia
                    cl.provincia = new entProvincia();
                    cl.provincia.Codigo = dr["ProvinciaCodigo"].ToString();
                    cl.provincia.NombreProv = dr["ProvinciaNombre"].ToString();

                    cl.Estado = Convert.ToBoolean(dr["Estado"]);
                    cl.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);

                    lista.Add(cl);
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
        public Boolean InsertarCliente(entCliente cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsetarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", cli.Nombre);
                cmd.Parameters.AddWithValue("@Mail", cli.Mail);
                cmd.Parameters.AddWithValue("@Web", cli.Web);
                cmd.Parameters.AddWithValue("@ProvinciaId", cli.provincia.Codigo);
                cmd.Parameters.AddWithValue("@CategoriaId", cli.categoria.Id);
                cmd.Parameters.AddWithValue("@NuevoId", 0);

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

        //deshabilitaCategoria
        public Boolean DeshabilitarClie(entCliente cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", cli.Id);
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

        public Boolean EditarCliente(entCliente cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", cli.Id);
                cmd.Parameters.AddWithValue("@Nombre", cli.Nombre);
                cmd.Parameters.AddWithValue("@Web", cli.Web);
                cmd.Parameters.AddWithValue("@ProvinciaId", cli.provincia.Codigo);
                cmd.Parameters.AddWithValue("@CategoriaId", cli.categoria.Id);
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
    }
        #endregion metodos
    
}
