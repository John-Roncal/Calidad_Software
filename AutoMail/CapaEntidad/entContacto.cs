using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entContacto
    {
        public int Id { get; set; }
        public entCliente Cliente { get; set; }
        public string Propuesta { get; set; }
        public string Comentarios { get; set; }
    }
}
