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
    public class datCategoria
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCategoria _instancia = new datCategoria();
        //privado para evitar la instanciación directa
        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }
        #endregion singleton

        #region CATEGORIA

        ////////////////////listado de Categorias
        public List<entCategoria> ListarCategorias()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria Cat = new entCategoria();
                    Cat.Id = Convert.ToInt32(dr["Id"]);
                    Cat.Nombre = dr["Nombre"].ToString();
                    Cat.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Cat);
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

        /*public Boolean ExisteNombreCategoria(string NomCategoria)
        {
            SqlCommand cmd = null;
            Boolean existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteNombreCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", NomCategoria);
                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    existe = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return existe;
        }*/

        /////////////////////////InsertaCategoria
        public Boolean InsertarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsetarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cat.Nombre);
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

        public Boolean EditarCategoria(entCategoria cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", cat.Id);
                cmd.Parameters.AddWithValue("@Nombre", cat.Nombre);
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
        public Boolean DeshabilitarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Cat.Id);
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

        public DataTable CargarCategoria()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarCategoria", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion CATEGORIA

    }
}