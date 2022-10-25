using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorG8.AccesoADatos
{
    internal class AD_Partidos
    {
        public static DataTable cargarComboClub()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM CLUBES";

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
        public static DataTable cargarComboClub2(int codigoLocal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                             "     FROM CLUBES WHERE ID_CLUB != @cod ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", codigoLocal);

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
        public static DataTable cargarComboCategoria()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM CATEGORIAS";

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
        public static DataTable cargarComboCancha()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM CANCHAS";

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
        public static DataTable cargarComboPuesto()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                    "              FROM PUESTOS";

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

        public static DataTable cargarCargo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT *" +
                             "     FROM CARGO";

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
            catch ( Exception ex )
            {
                throw;
            }
            finally { cn.Close();  }



            }

        public static DataTable ObtenerJugadorXId(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT S.NOMBRE, S.APELLIDO, C.NOMBRE " +
                    "              FROM JUGADORES J INNER JOIN SOCIOS S ON (J.ID_SOCIO = S.ID_SOCIO)" +
                    "                   INNER JOIN CLUBES C ON (J.ID_CLUB = C.ID_CLUB) " +
                    "              WHERE ID_JUGADOR = @id";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

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

        public static DataTable ObtenerArbitroXId(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT A.NOMBRE, A.APELLIDO" +
                    "              FROM ARBITROS A " +
                    "              WHERE ID_ARBITRO = @id";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

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

        public static bool altaNuevoPartido(DateTime fecha, int codCategoria, int nroCancha, int idClub, int idClubVisitante, int nroCamiseta, int codPuesto, string titular, int codCargo, List<int> listaIdsJugadores, List<int> listaIdsArbitros)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction sqlTransaction = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO PARTIDOS" +
                    "              VALUES (@fecha, @codCategoria, @nroCancha, @idClub, @idClubLocal, @idClubVisitante)";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@codCategoria", codCategoria);
                cmd.Parameters.AddWithValue("@nroCancha", nroCancha);
                cmd.Parameters.AddWithValue("@idClub", idClub);
                cmd.Parameters.AddWithValue("@idClubLocal", idClub);
                cmd.Parameters.AddWithValue("@idClubVisitante", idClubVisitante);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                sqlTransaction = cn.BeginTransaction("AltaDePartido");

                cmd.Transaction = sqlTransaction;
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach (var id in listaIdsJugadores)
                {
                    string query1 = "INSERT INTO JUGADORXEQUIPOXPARTIDO" +
                        "           VALUES (@idJugador, @fecha, @codCategoria, @idClubLocal, @nroCamiseta, @codPuesto, @titular)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idJugador", id);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@codCategoria", codCategoria);
                    cmd.Parameters.AddWithValue("@idClubLocal", idClub);
                    cmd.Parameters.AddWithValue("@nroCamiseta", nroCamiseta);
                    cmd.Parameters.AddWithValue("@codPuesto", codPuesto);
                    cmd.Parameters.AddWithValue("@titular", titular);



                    cmd.CommandText = query1;

                    cmd.ExecuteNonQuery();
                }

                foreach (var id in listaIdsJugadores)
                {
                    string query2 = "INSERT INTO ARBITROXPARTIDO" +
                        "           VALUES (@idArbitro, @fecha, @codCategoria, @idClub, @codCargo)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idArbitro", id);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@codCategoria", codCategoria);
                    cmd.Parameters.AddWithValue("@idClub", idClub);
                    cmd.Parameters.AddWithValue("@codCargo", codCargo);

                    cmd.CommandText = query2;

                    cmd.ExecuteNonQuery();
                }

                sqlTransaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                return false;
            }
            finally { cn.Close(); }


        }
    }
}
