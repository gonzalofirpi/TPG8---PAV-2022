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
    public class AD_Clubes
    {
        public static DataTable obtenerBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetBarrios";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //cn.Close();
            }
        }

        public static DataTable obtenerListadoClubes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetListadoClubes";

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

        public static DataTable obtenerClubes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CLUBES";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
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

        public static bool agregarClubBD(Club club)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertClub";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", club.Nombre);
                cmd.Parameters.AddWithValue("@nroCuit", club.NroCuit);
                cmd.Parameters.AddWithValue("@calle", club.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", club.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", club.Barrio);
                cmd.Parameters.AddWithValue("@fechaFundacion", club.FechaFundacion);

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

        public static Club obtenerClub(long nroCuit)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Club club = new Club();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetClub";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", nroCuit);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    club.Id = int.Parse(dr["ID_CLUB"].ToString());
                    club.Nombre = dr["NOMBRE"].ToString();
                    club.NroCuit = long.Parse(dr["NROCUIT"].ToString());
                    club.Calle = dr["CALLE"].ToString();
                    club.NroCalle = int.Parse(dr["NRO_CALLE"].ToString());
                    club.Barrio = int.Parse(dr["COD_BARRIO"].ToString());
                    club.FechaFundacion = DateTime.Parse(dr["FECHA_FUNDACION"].ToString());
                }

                return club;
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

        public static bool actualizarClub(Club club, int idClub)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateClub";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idClub);
                cmd.Parameters.AddWithValue("@nombre", club.Nombre);
                cmd.Parameters.AddWithValue("@nroCuit", club.NroCuit);
                cmd.Parameters.AddWithValue("@calle", club.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", club.NroCalle);
                cmd.Parameters.AddWithValue("@codBarrio", club.Barrio);
                cmd.Parameters.AddWithValue("@fechaFundacion", club.FechaFundacion);

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

        public static bool borrarClub(int idClub)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteClub";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idClub);

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
