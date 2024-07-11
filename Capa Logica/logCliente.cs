using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Logica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton

        //#region metodos
        ///listado
        
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        public Boolean InsertarCliente(entCliente Cl, entCiudad ci, entProfesion pr)
        {
            return datCliente.Instancia.InsertarCliente(Cl, ci, pr);
        }
        public Boolean ModificarCliente(entCliente Cl, entCiudad ci, entProfesion pr)
        {
            return datCliente.Instancia.ModificarCliente(Cl, ci, pr);
        }
        public Boolean DeshabilitarCliente(entCliente Cl)
        {
            return datCliente.Instancia.DeshabilitarCliente(Cl);
        }
        public List<entCliente> BuscarCliente(entCliente Cl)
        {
            return datCliente.Instancia.BuscarCliente(Cl);
        }

    }
}
