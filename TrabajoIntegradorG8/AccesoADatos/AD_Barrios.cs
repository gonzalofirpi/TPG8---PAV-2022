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
    public class AD_Barrios
    {
        public static DataTable obtenerLocalidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetLocalidades";

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

        public static DataTable obtenerListadoBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetListadoBarrios";

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

        public static bool existeCodigoPostal(int codPostal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetCodPostal";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codPostal);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

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

        public static bool agregarBarrioBD(Barrio barrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", barrio.Nombre);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.Localidad);
                cmd.Parameters.AddWithValue("@codPostal", barrio.CodPostal);

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

        public static Barrio obtenerBarrio(int codBarrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio barrio = new Barrio();

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "GetBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codBarrio);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    barrio.Codigo = int.Parse(dr["COD_BARRIO"].ToString());
                    barrio.Nombre = dr["NOMBRE"].ToString();
                    barrio.Localidad = int.Parse(dr["COD_LOCALIDAD"].ToString());
                    barrio.CodPostal = int.Parse(dr["COD_POSTAL"].ToString());
                }

                return barrio;
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

        public static bool actualizarBarrio(Barrio barrio, int codBarrio)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UpdateBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", codBarrio);
                cmd.Parameters.AddWithValue("@nombre", barrio.Nombre);
                cmd.Parameters.AddWithValue("@codLocalidad", barrio.Localidad);
                cmd.Parameters.AddWithValue("@codPostal", barrio.CodPostal);

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

        public static bool borrarBarrio(int codBarrio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codBarrio", codBarrio);

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
