using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Data;

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
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.NombreClie = dr["NombreClie"].ToString();
                    Cli.ApellidoClie = dr["ApellidoClie"].ToString();
                    Cli.GeneroClie = dr["GeneroClie"].ToString();
                    Cli.EdadClie = Convert.ToInt32(dr["EdadClie"]);
                    Cli.FechaNaClie = Convert.ToDateTime(dr["FechaNaClie"]);
                    Cli.TelefonoClie = Convert.ToInt32(dr["TelefonoClie"]);
                    Cli.EstadoClie = Convert.ToBoolean(dr["EstadoClie"]);
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
        #endregion metodos
    }
}
