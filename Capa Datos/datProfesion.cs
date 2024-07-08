using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class datProfesion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProfesion _instancia = new datProfesion();
        //privado para evitar la instanciación directa
        public static datProfesion Instancia
        {
            get
            {
                return datProfesion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entProfesion> ListarProfesion()
        {
            SqlCommand cmd = null;
            List<entProfesion> lista = new List<entProfesion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProfesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProfesion Pr = new entProfesion();
                    Pr.ProfesionID = Convert.ToInt32(dr["ProfesionID"]);
                    Pr.NombreProfe = dr["NombreProfe"].ToString();
                    Pr.DescripcionProfe = dr["DescripcionProfe"].ToString();
                    lista.Add(Pr);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarProfesion(entProfesion Pr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProfesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreProfe", Pr.NombreProfe);
                cmd.Parameters.AddWithValue("@DescripcionProfe", Pr.DescripcionProfe);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean ModificarProfesion(entProfesion Pr)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProfesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProfesionID", Pr.ProfesionID);
                cmd.Parameters.AddWithValue("@NombreProfe", Pr.NombreProfe);
                cmd.Parameters.AddWithValue("@DescripcionProfe", Pr.DescripcionProfe);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificar = true;
                }

            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return modificar;
        }

        public Boolean EliminarProfesion(entProfesion Pr)
        {
            SqlCommand cmd = null;
            Boolean eliminar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProfesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProfesionID", Pr.ProfesionID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return eliminar;
        }
        

        #endregion metodos

    }
}
