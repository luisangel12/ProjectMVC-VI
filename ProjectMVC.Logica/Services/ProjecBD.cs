using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMVC.Logica.Models.DB;

namespace ProjectMVC.Logica.Services
{
    public class ProjecBD : Interfaces.IProjec
    {

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private SqlDataAdapter dataAdapter = null;

        public List<Matches> GetMatches()
        {
            try
            {
                var listActivities = new List<Logica.Models.DB.Matches>();

                connection = Data.ConnectionDB.GetConnection();
                command = new SqlCommand("ParcialProject", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                DataSet result = new DataSet();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(result);

                foreach (DataRow item in result.Tables[0].Rows)
                {
                    listActivities.Add(new Models.DB.Matches
                    {
                        
                         Name = (string)item["Name"],
                         partidos_jugados= (int)item["partidos_jugados"],
                         Goles_a_Favor= (int)item["Goles_a_Favor"],
                         Goles_en_Contra= (int)item["Goles_en_Contra"],
                         Posicion= (int)item["Posicion"],
                         Puntos= (int)item["Puntos"],
                         Partidos_Ganados = (int)item["Partidos_Ganados"],
                         Partidos_Perdidos = (int)item["Partidos_Perdidos"],
                         Diferencia_de_Goles = (int)item["Diferencia_de_Goles"]

                    });
                }

                return listActivities;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
