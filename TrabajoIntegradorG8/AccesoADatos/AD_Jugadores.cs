using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorG8.Entidades;

namespace TrabajoIntegradorG8.AccesoADatos
{
    public class AD_Jugadores
    {
        

        public static DataTable obtenerListadoJugadores()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetListadoJugadores";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

       
        public static bool agregarJugadorBD(Jugador jugador)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertJugador";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idJugador", jugador.idJugador);
                cmd.Parameters.AddWithValue("@idSocio", jugador.idSocio);
                cmd.Parameters.AddWithValue("@idClub", jugador.idClub);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Jugador obtenerJugador(int idJugador)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Jugador jugador = new Jugador();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetJugador";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idJugador", idJugador);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    jugador.idJugador = int.Parse(dr["ID_JUGADOR"].ToString());
                    jugador.idSocio = dr["ID_SOCIO"].ToString();
                    jugador.idClub = int.Parse(dr["ID_CLUB"].ToString());
                }

                return jugador;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static bool actualizarJugador(Jugador jugador, int idJugador)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateJugador";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idJugador", idJugador);
                cmd.Parameters.AddWithValue("@idSocio", jugador.idSocio);
                cmd.Parameters.AddWithValue("@idClub", jugador.Club);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool borrarJugador(int idJugador)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteJugador";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idJugador", idJugador);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}