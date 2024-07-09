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
    public class datTipoEmpleado
    {
        #region sigleton

        private static readonly datTipoEmpleado _instancia = new datTipoEmpleado();

        public static datTipoEmpleado Instancia
        {
            get
            {
                return datTipoEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTipoEmpleado> ListarTipoEmpleado()
        {
            SqlCommand cmd = null;
            List<entTipoEmpleado> lista = new List<entTipoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEmpleado Tp = new entTipoEmpleado();
                    Tp.TipoEmpleadoID = Convert.ToInt32(dr["TipoEmpleadoID"]);
                    Tp.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    Tp.Contrato = dr["Contrato"].ToString();
                    Tp.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(Tp);
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

        public List<entTipoEmpleado> ListarTipoEmpleado1()
        {
            SqlCommand cmd = null;
            List<entTipoEmpleado> lista = new List<entTipoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoEmpleado1", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEmpleado Tp = new entTipoEmpleado();
                    Tp.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    lista.Add(Tp);
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

        public Boolean InsertarTipoEmpleado(entTipoEmpleado Pt)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreTipoEmpl", Pt.NombreTipoEmpl);
                cmd.Parameters.AddWithValue("@Contrato", Pt.Contrato);
                cmd.Parameters.AddWithValue("@Descripcion", Pt.Descripcion);
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
        public Boolean ModificarTipoEmpleado(entTipoEmpleado Pt)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoEmpleadoID", Pt.TipoEmpleadoID);
                cmd.Parameters.AddWithValue("@NombreTipoEmpl", Pt.NombreTipoEmpl);
                cmd.Parameters.AddWithValue("@Contrato", Pt.Contrato);
                cmd.Parameters.AddWithValue("@Descripcion", Pt.Descripcion);
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

        public Boolean EliminarTipoEmpleado(entTipoEmpleado Pt)
        {
            SqlCommand cmd = null;
            Boolean eliminar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoEmpleadoID", Pt.TipoEmpleadoID);
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

        public List<entTipoEmpleado> BuscarTipoEmpleado(entTipoEmpleado Tp)
        {
            SqlCommand cmd = null;
            List<entTipoEmpleado> lista = new List<entTipoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreTipoEmpl", Tp.NombreTipoEmpl);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEmpleado Tpi = new entTipoEmpleado();
                    Tpi.TipoEmpleadoID = Convert.ToInt32(dr["TipoEmpleadoID"]);
                    Tpi.NombreTipoEmpl = dr["NombreTipoEmpl"].ToString();
                    Tpi.Contrato = dr["Contrato"].ToString();
                    Tpi.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(Tpi);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        #endregion metodos

    }
}
