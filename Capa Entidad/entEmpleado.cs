using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entEmpleado
    {
        public int EmpleadoID { get; set; }
        public int TipoEmpleado { get; set; }
        public string NombreTipoEmpl { get; set; }
        public string NombreEmpl { get; set; }
        public string DNIEmpl { get; set; }
        public string CorreoEmpl { get; set; }
        public string TelefonoEmpl { get; set; }
        public Boolean  EstadoEmpl { get; set; }
    }
}
