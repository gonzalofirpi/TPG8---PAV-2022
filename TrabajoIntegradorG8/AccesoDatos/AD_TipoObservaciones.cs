﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorG8.Entidad;

namespace TrabajoIntegradorG8.AccesoDatos
{
    class AD_TipoObservaciones
    {
        public static DataTable ObtenerListadoObservaciones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Select * from TIPO_OBSERVACIONES";

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

        public static bool agregarObservacion(TipoObservaciones observacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert into TIPO_OBSERVACIONES (NOMBRE) VALUES (@NOMBRE)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NOMBRE", observacion.Nombre);
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

        public static TipoObservaciones obtenerObservacion(int codObservacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoObservaciones observacion = new Entidad.TipoObservaciones();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TIPO_OBSERVACIONES WHERE COD_OBSERVACION LIKE @CODOBSERVACION";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODOBSERVACION", codObservacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;


                SqlDataReader c = cmd.ExecuteReader();
                if (c != null && c.Read())
                {
                    observacion.Codigo = int.Parse(c["COD_OBSERVACION"].ToString());
                    observacion.Nombre = c["NOMBRE"].ToString();

                }

                return observacion;


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

        public static bool actualizarObservacion(TipoObservaciones  observacion, int codObservacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE  TIPO_OBSERVACIONES SET NOMBRE = @NOMBRE where  COD_OBSERVACION like @CODOBSERVACION ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODOBSERVACION", codObservacion);
                cmd.Parameters.AddWithValue("@NOMBRE", observacion.Nombre);
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

        public static bool borrarObservacion(int codObservacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM TIPO_OBSERVACIONES WHERE COD_OBSERVACION LIKE @CODOBSERVACION";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CODOBSERVACION", codObservacion);
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
