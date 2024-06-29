using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entCliente
    {
        public int ClienteID { get; set; }
        public string NombreClie { get; set; }
        public string ApellidoClie { get; set; }
        public string GeneroClie { get; set; }
        public int EdadClie { get; set; }
        public DateTime FechaNaClie { get; set; }
        public int TelefonoClie { get; set; }
        public Boolean EstadoClie { get; set; }
    }
}
