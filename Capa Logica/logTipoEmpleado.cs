using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logTipoEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoEmpleado _instancia = new logTipoEmpleado();
        //privado para evitar la instanciación directa
        public static logTipoEmpleado Instancia
        {
            get
            {
                return logTipoEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entTipoEmpleado> ListarTipoEmpleado()
        {
            return datTipoEmpleado.Instancia.ListarTipoEmpleado();
        }
        public List<entTipoEmpleado> ListarTipoEmpleado1()
        {
            return datTipoEmpleado.Instancia.ListarTipoEmpleado1();
        }
        public void InsertarTipoEmpleado(entTipoEmpleado Pr)
        {
            datTipoEmpleado.Instancia.InsertarTipoEmpleado(Pr);
        }
        public void ModificarTipoEmpleado(entTipoEmpleado Pr)
        {
            datTipoEmpleado.Instancia.ModificarTipoEmpleado(Pr);
        }
        public void EliminarTipoEmpleado(entTipoEmpleado Pr)
        {
            datTipoEmpleado.Instancia.EliminarTipoEmpleado(Pr);
        }
        #endregion metodos
    }
}
