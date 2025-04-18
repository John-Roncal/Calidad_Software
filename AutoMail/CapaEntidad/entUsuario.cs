using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int UsuarioID { get; set; }

        public int RolID { get; set; }
        public string Usuario { get; set; }

        // Contraseña en formato hash (varbinary en SQL)
        public byte[] Clave { get; set; }

        public bool EstadoUsuario { get; set; }
    }
}