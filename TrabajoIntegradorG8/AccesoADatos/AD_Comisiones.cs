using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.AccesoADatos
{
    internal class AD_Comisiones
    {
        public static DataTable ObtenerEstadisticasComisiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT C.NOMBRE as Nombre, COUNT(CO.ID_CLUB) as Cantidad\r\nFROM CLUBES C inner join COMISIONES CO ON (C.ID_CLUB = CO.ID_CLUB) WHERE YEAR(GETDATE()) - YEAR(CO.FECHA_DESDE) <= 10 GROUP BY C.NOMBRE;";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable Tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Tabla);

            return Tabla;
        }
    }
}
