using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logCiudad
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCiudad _instancia = new logCiudad();
        //privado para evitar la instanciación directa
        public static logCiudad Instancia
        {
            get
            {
                return logCiudad._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entCiudad> ListarCiudad()
        {
            return datCiudad.Instancia.ListarCiudad();
        }
        public void InsertarCiudad(entCiudad Ciu)
        {
            datCiudad.Instancia.InsertarCiudad(Ciu);
        }
        public void ModificarCiudad(entCiudad Ciu)
        {
            datCiudad.Instancia.ModificarCiudad(Ciu);
        }
        public void DeshabilitarCiudad(entCiudad Ciu)
        {
            datCiudad.Instancia.DeshabilitarCiudad(Ciu);
        }
        #endregion metodos
    }
}
