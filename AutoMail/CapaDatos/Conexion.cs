using Microsoft.Data.SqlClient;
using System;

namespace CapaDatos
{
    public class Conexion
    {
        // Patrón Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return _instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=localhost;Initial Catalog=NorRevistaBD;Integrated Security=True;TrustServerCertificate=True";
            return cn;
        }
    }
}
