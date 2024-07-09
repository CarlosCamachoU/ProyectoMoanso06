using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logEmpleado
    {
        #region sigleton

        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton

        //#region metodos
        ///listado

        public List<entEmpleado> ListarEmpleado()
        {
            return datEmpleado.Instancia.ListarEmpleado();
        }
        public Boolean InsertarEmpleado(entEmpleado Emp, entTipoEmpleado Tp)
        {
            return datEmpleado.Instancia.InsertarEmpleado(Emp, Tp);
        }
        public Boolean ModificarEmpleado(entEmpleado Emp, entTipoEmpleado Tp)
        {
            return datEmpleado.Instancia.InsertarEmpleado(Emp, Tp);
        }
        public Boolean DeshabilitarEmpleado(entEmpleado Emp)
        {
            return datEmpleado.Instancia.DeshabilitarEmpleado(Emp);
        }
        public List<entEmpleado> BuscarEmpleado(entEmpleado Emp)
        {
            return datEmpleado.Instancia.BuscarEmpleado(Emp);
        }
    }
}
