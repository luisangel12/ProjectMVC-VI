using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ProjectMVC.Logica.Data
{
   public class ConnectionParcialMVC
    {

        private static SqlConnection connection = null;

        /// <summary>
        /// METODO QUE CIERRA LA CONEXION
        /// </summary>
        public static void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// METODO QUE ESTABLECE LA CONEXION
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            try
            {
                if (connection == null)
                {
                    string Project = ConfigurationManager.ConnectionStrings["Project"].ToString();
                    connection = new SqlConnection(Project);
                    connection.Open();
                }

                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
