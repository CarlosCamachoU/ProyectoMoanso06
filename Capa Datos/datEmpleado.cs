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
    public class datEmpleado
    {
        #region sigleton
 
        private static readonly datEmpleado _instancia = new datEmpleado();

        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Emp = new entEmpleado();
                    entTipoEmpleado TP = new entTipoEmpleado();

                    Emp.EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]);
                    TP.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    Emp.NombreEmpl = dr["NombreEmpl"].ToString();
                    Emp.DNIEmpl = dr["DNIEmpl"].ToString();
                    Emp.CorreoEmpl = dr["CorreoEmpl"].ToString();
                    Emp.TelefonoEmpl = dr["TelefonoEmpl"].ToString();
                    Emp.EstadoEmpl = Convert.ToBoolean(dr["EstadoEmpl"]);
                    Emp.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    lista.Add(Emp);
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

        public Boolean InsertarEmpleado(entEmpleado Emp, entTipoEmpleado Tipoempleado)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoEmpleadoID", BuscarTipoEmpleado(Tipoempleado));
                cmd.Parameters.AddWithValue("@NombreEmpl", Emp.NombreEmpl);
                cmd.Parameters.AddWithValue("@DNIEmpl", Emp.DNIEmpl);
                cmd.Parameters.AddWithValue("@CorreoEmpl", Emp.CorreoEmpl);
                cmd.Parameters.AddWithValue("@TelefonoEmpl", Emp.TelefonoEmpl);
                cmd.Parameters.AddWithValue("@EstadoEmpl", Emp.EstadoEmpl);
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

        public Boolean ModificarEmpleado(entEmpleado Emp, entTipoEmpleado Tipoempleado)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Emp.EmpleadoID);
                cmd.Parameters.AddWithValue("@TipoEmpleadoID", BuscarTipoEmpleado(Tipoempleado));
                cmd.Parameters.AddWithValue("@NombreEmpl", Emp.NombreEmpl);
                cmd.Parameters.AddWithValue("@DNIEmpl", Emp.DNIEmpl);
                cmd.Parameters.AddWithValue("@CorreoEmpl", Emp.CorreoEmpl);
                cmd.Parameters.AddWithValue("@TelefonoEmpl", Emp.TelefonoEmpl);
                cmd.Parameters.AddWithValue("@EstadoEmpl", Emp.EstadoEmpl);
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

        public Boolean DeshabilitarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Emp.EmpleadoID);
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
        public List<entEmpleado> BuscarEmpleado(entEmpleado Empi)
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DNIEmpl", Empi.DNIEmpl);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Emp = new entEmpleado();
                    entTipoEmpleado TP = new entTipoEmpleado();

                    Emp.EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]);
                    TP.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    Emp.NombreEmpl = dr["NombreEmpl"].ToString();
                    Emp.DNIEmpl = dr["DNIEmpl"].ToString();
                    Emp.CorreoEmpl = dr["CorreoEmpl"].ToString();
                    Emp.TelefonoEmpl = dr["TelefonoEmpl"].ToString();
                    Emp.EstadoEmpl = Convert.ToBoolean(dr["EstadoEmpl"]);
                    Emp.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    lista.Add(Emp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }


        public int BuscarTipoEmpleado(entTipoEmpleado tipoempleado)
        {
            int id = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarIDTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreTipoEmpl", tipoempleado.NombreTipoEmpl);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["TipoEmpleadoID"]);
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
