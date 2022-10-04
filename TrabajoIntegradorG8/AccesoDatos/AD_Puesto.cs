using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorG8.Entidad;

namespace TrabajoIntegradorG8.AccesoDatos
{
    class AD_Puesto
    {
        public static DataTable ObtenerListadoPuestos() 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * from PUESTOS";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                return tabla;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool agregarPuesto(Puesto puesto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert into PUESTOS (NOMBRE) VALUES (@NOMBRE)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NOMBRE", puesto.Nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                return true;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Puesto obtenerPuesto(int codPuesto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Puesto puesto = new Puesto();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM PUESTOS WHERE COD_PUESTO LIKE @CODPUESTO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODPUESTO", codPuesto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;


                SqlDataReader c = cmd.ExecuteReader();
                if (c != null && c.Read())
                {
                    puesto.Codigo = int.Parse(c["COD_PUESTO"].ToString());
                    puesto.Nombre = c["NOMBRE"].ToString();
                    
                }
                
                return puesto;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool actualizarPuesto(Puesto puesto, int codPuesto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE  PUESTOS SET NOMBRE = @NOMBRE where  COD_PUESTO like @CODPUESTO ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODPUESTO", codPuesto);
                cmd.Parameters.AddWithValue("@NOMBRE", puesto.Nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                
                return true;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool borrarPuesto (int codPuesto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM PUESTOS WHERE COD_PUESTO LIKE @CODPUESTO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODPUESTO", codPuesto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                return true;


            }
            catch (Exception)
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
