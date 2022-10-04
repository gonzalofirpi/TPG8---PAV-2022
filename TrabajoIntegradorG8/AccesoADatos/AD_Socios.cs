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
    public class AD_Socios
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

        public static DataTable obtenerListadoSocios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetListadoSocios";

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

        public static bool agregarSocioBD(Socio socio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertSocio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", socio.Nombre);
                cmd.Parameters.AddWithValue("@apellido", socio.Apellido);
                cmd.Parameters.AddWithValue("@calle", socio.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", socio.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", socio.Barrio);
                cmd.Parameters.AddWithValue("@fechaNacimiento", socio.FechaNacimiento);

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

        public static Socio obtenerSocio(string apellido)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Socio socio = new Socio();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetSocio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuit", nroCuit);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    socio.Id = int.Parse(dr["ID_SOCIO"].ToString());
                    socio.Nombre = dr["NOMBRE"].ToString();
                    socio.NroCuit = long.Parse(dr["APELLIDO"].ToString());
                    socio.Calle = dr["CALLE"].ToString();
                    socio.NroCalle = int.Parse(dr["NRO_CALLE"].ToString());
                    socio.Barrio = int.Parse(dr["COD_BARRIO"].ToString());
                    socio.FechaNacimiento = DateTime.Parse(dr["FECHA_NACIMIENTO"].ToString());
                }

                return socio;
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

        public static bool actualizarSocio(Socio socio, int idSocio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateSocio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idSocio);
                cmd.Parameters.AddWithValue("@nombre", socio.Nombre);
                cmd.Parameters.AddWithValue("@apellido", socio.Apellido);
                cmd.Parameters.AddWithValue("@calle", socio.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", socio.NroCalle);
                cmd.Parameters.AddWithValue("@codBarrio", socio.Barrio);
                cmd.Parameters.AddWithValue("@fechaNacimiento", socio.FechaNacimiento);

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

        public static bool borrarSocio(int idSocio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteSocio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idSocio);

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