using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace Capa_Datos
{
    public class datCiudad
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCiudad _instancia = new datCiudad();
        //privado para evitar la instanciación directa
        public static datCiudad Instancia
        {
            get
            {
                return datCiudad._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Ciudad
        public List<entCiudad> ListarCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> lista = new List<entCiudad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCiudad Ciu = new entCiudad();
                    Ciu.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    Ciu.NombreCiudad = dr["NombreCiudad"].ToString();
                    Ciu.EstadoCiudad = Convert.ToBoolean(dr["EstadoCiudad"]);
                    lista.Add(Ciu);
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

        /////////////////////////InsertaCiudad
        public Boolean InsertarCiudad(entCiudad Ciu)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCiudad", Ciu.NombreCiudad);
                cmd.Parameters.AddWithValue("@estCiudad", Ciu.EstadoCiudad);
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

        public Boolean ModificarCiudad(entCiudad Ciu)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCiudad", Ciu.NombreCiudad);
                cmd.Parameters.AddWithValue("@estCliente", Ciu.EstadoCiudad);
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

        //deshabilitaCliente
        public Boolean DeshabilitarCiudad(entCiudad Ciu)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", Ciu.CiudadID);
                cmd.Parameters.AddWithValue("@estCiudad", Ciu.EstadoCiudad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deshabilitar;
        }


        #endregion metodos
    }
}
