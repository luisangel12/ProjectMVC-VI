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
    public class Vehicle_Projectcs : Interfaces.Vehicle_Project
    {

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private SqlDataAdapter dataAdapter = null;

        public List<TypeServices> GetTypeServices()
        {
            throw new NotImplementedException();
        }

        public List<Vehicles> GetVehicles()
        {
            try
            {
                var listVehicles = new List<Logica.Models.DB.Vehicles>();

                connection = Data.ConnectionDB.GetConnection();
                command = new SqlCommand("GetVehicles", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                DataSet result = new DataSet();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(result);

                foreach (DataRow item in result.Tables[0].Rows)
                {
                    listVehicles.Add(new Models.DB.Vehicles
                    {
                        Id = (int)item["Id"],
                        LicensePlate = (string)item["LicensePlate"],
                        NroTransitLicense = (string)item["NroTransitLicense"],
                       StateVehicle = (bool)item["StateVehicle"],
                        //TypeServiceId = (int)item["TypeServiceId"],
                        //ClassVehicleId = (int)item["ClassVehicleId"],
                        Image = (string)item["Image"],
                        CustomerId = (int)item["CustomerId"]

                    });
                }

                return listVehicles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


