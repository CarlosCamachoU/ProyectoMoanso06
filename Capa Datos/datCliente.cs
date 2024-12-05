using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Data;
using System.Collections;

namespace Capa_Datos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
       public List<entCliente> ListarCliente()
       {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    entCiudad Ciu = new entCiudad();
                    entProfesion Pr = new entProfesion();
                    //Cli.Ciudad = Ciu;
                    //Cli.Profesion = Pr;
                    Ciu.NombreCiudad = dr["NombreCiudad"].ToString();
                    Pr.NombreProfe = dr["NombreProfe"].ToString();
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.NombreClie = dr["NombreClie"].ToString();
                    Cli.ApellidoClie = dr["ApellidoClie"].ToString();
                    Cli.FechaNaClie = Convert.ToDateTime(dr["FechaNaClie"]);
                    Cli.GeneroClie = dr["GeneroClie"].ToString();
                    Cli.EdadClie = Convert.ToInt32(dr["EdadClie"]);
                    Cli.DNIClie = dr["DNIClie"].ToString();
                    Cli.TelefonoClie = dr["TelefonoClie"].ToString();
                    Cli.EstadoClie = Convert.ToBoolean(dr["EstadoClie"]);
                    Cli.DireccionClie = dr["DireccionClie"].ToString();
                    Cli.NombreCiudad = dr["NombreCiudad"].ToString();
                    Cli.NombreProfesion = dr["NombreProfe"].ToString();
                    lista.Add(Cli);
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

        public Boolean InsertarCliente(entCliente Cli, entCiudad ciudad, entProfesion profesion)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadID", BuscarCiudad(ciudad));
                cmd.Parameters.AddWithValue("@ProfesionID", BuscarProfesion(profesion));
                cmd.Parameters.AddWithValue("@NombreClie", Cli.NombreClie);
                cmd.Parameters.AddWithValue("@ApellidoClie", Cli.ApellidoClie);
                cmd.Parameters.AddWithValue("@FechaNaClie", Cli.FechaNaClie);
                cmd.Parameters.AddWithValue("@EdadClie", Cli.EdadClie);
                cmd.Parameters.AddWithValue("@GeneroClie", Cli.GeneroClie);
                cmd.Parameters.AddWithValue("@DNIClie", Cli.DNIClie);
                cmd.Parameters.AddWithValue("@TelefonoClie", Cli.TelefonoClie);
                cmd.Parameters.AddWithValue("@EstadoClie", Cli.EstadoClie);
                cmd.Parameters.AddWithValue("@DireccionClie", Cli.DireccionClie);
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

        public Boolean ModificarCliente(entCliente Cli, entCiudad ciudad, entProfesion profesion)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@CiudadID", BuscarCiudad(ciudad));
                cmd.Parameters.AddWithValue("@ProfesionID", BuscarProfesion(profesion));
                cmd.Parameters.AddWithValue("@NombreClie", Cli.NombreClie);
                cmd.Parameters.AddWithValue("@ApellidoClie", Cli.ApellidoClie);
                cmd.Parameters.AddWithValue("@FechaNaClie", Cli.FechaNaClie);
                cmd.Parameters.AddWithValue("@EdadClie", Cli.EdadClie);
                cmd.Parameters.AddWithValue("@GeneroClie", Cli.GeneroClie);
                cmd.Parameters.AddWithValue("@DNIClie", Cli.DNIClie);
                cmd.Parameters.AddWithValue("@TelefonoClie", Cli.TelefonoClie);
                cmd.Parameters.AddWithValue("@EstadoClie", Cli.EstadoClie);
                cmd.Parameters.AddWithValue("@DireccionClie", Cli.DireccionClie);
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

        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID",Cli.ClienteID);
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
        
        public List<entCliente> BuscarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DNIClie", Cli.DNIClie);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Clie = new entCliente();
                    entCiudad Ciu = new entCiudad();
                    entProfesion Pr = new entProfesion();

                    Clie.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Clie.NombreClie = dr["NombreClie"].ToString();
                    Clie.ApellidoClie = dr["ApellidoClie"].ToString();
                    Clie.FechaNaClie = Convert.ToDateTime(dr["FechaNaClie"]);
                    Clie.GeneroClie = dr["GeneroClie"].ToString();
                    Clie.EdadClie = Convert.ToInt32(dr["EdadClie"]);
                    Clie.DNIClie = dr["DNIClie"].ToString();
                    Clie.TelefonoClie = dr["TelefonoClie"].ToString();
                    Clie.EstadoClie = Convert.ToBoolean(dr["EstadoClie"]);
                    Clie.DireccionClie = dr["DireccionClie"].ToString();
                    Clie.NombreCiudad = dr["NombreCiudad"].ToString();
                    Clie.NombreProfesion = dr["NombreProfe"].ToString();
                    lista.Add(Clie);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public int BuscarCiudad(entCiudad ciudad)
        {
            int id = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarIDCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCiudad", ciudad.NombreCiudad);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["CiudadID"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return id;

        }

        public int BuscarProfesion(entProfesion profesion)
        {
            int id = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarIDProfesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreProfe", profesion. NombreProfe);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["ProfesionID"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return id;
        }
        #endregion metodos
    }
}
