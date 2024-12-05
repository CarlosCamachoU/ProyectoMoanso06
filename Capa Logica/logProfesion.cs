using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logProfesion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProfesion _instancia = new logProfesion();
        //privado para evitar la instanciación directa
        public static logProfesion Instancia
        {
            get
            {
                return logProfesion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entProfesion> ListarProfesion()
        {
            return datProfesion.Instancia.ListarProfesion();
        }
        public List<entProfesion> ListarProfesion1()
        {
            return datProfesion.Instancia.ListarProfesion1();
        }
        public void InsertarProfesion(entProfesion Pr)
        {
            datProfesion.Instancia.InsertarProfesion(Pr);
        }
        public void ModificarProfesion(entProfesion Pr)
        {
            datProfesion.Instancia.ModificarProfesion(Pr);
        }
        public void EliminarProfesion(entProfesion Pr)
        {
            datProfesion.Instancia.EliminarProfesion(Pr);
        }
        #endregion metodos
    }
}
