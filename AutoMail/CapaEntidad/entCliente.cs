using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public entCategoria categoria { get; set; }
        public entProvincia provincia { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IDCategoria => categoria.Id;
        public string NombreCategoria => categoria?.Nombre;
        public string IDProvincia => provincia.Codigo;
        public string NombreProvincia => provincia?.NombreProv;
    }
}
