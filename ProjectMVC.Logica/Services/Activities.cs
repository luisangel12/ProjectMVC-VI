﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProjectMVC.Logica.Models.DB;

namespace ProjectMVC.Logica.Services
{
    public class Activities : Interfaces.IActivities
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;
        private SqlDataAdapter dataAdapter = null;

        /// <summary>
        /// METODO QUE CREA LA ACTIVIDAD
        /// </summary>
        /// <param name="name">NOMBRE DE LA ACTIVIDAD</param>
        public void CreateActivity(string name)
        {
            try
            {
                connection = Data.ConnectionDB.GetConnection();
                command = new SqlCommand("CreateActivity", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@name", name));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteActivity(int id)
        {
            throw new NotImplementedException();
        }

        //public List<Vehicles> GetVehicles()
        //{
        //    try
        //    {
        //        var listVehicles = new List<Logica.Models.DB.Vehicles>();

        //        connection = Data.ConnectionDB.GetConnection();
        //        command = new SqlCommand("GetVehicles", connection);
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.ExecuteNonQuery();

        //        DataSet result = new DataSet();
        //        dataAdapter = new SqlDataAdapter(command);
        //        dataAdapter.Fill(result);

        //        foreach (DataRow item in result.Tables[0].Rows)
        //        {
        //            listVehicles.Add(new Models.DB.Vehicles
        //            {
        //                Id = (int)item["Identificacion"],
        //                LicensePlate = (string)item["Placa"],
        //                NroTransitLicense = (string)item["Licencia de Transito"],
        //                StateVehicle = (int)item["Estado Vehiculo"],
        //                TypeServiceId = (int)item["Tipo de Servicio"],
        //                ClassVehicleId = (int)item["Case de Vehiculo"],
        //                Image = (string)item["Imagen"],
        //                CustomerId = (int)item["Cliente"]



        //            });
        //        }

        //        return listVehicles;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        /// <summary>
        /// METODO QU CONSULTA LAS ACTIVIDADES
        /// </summary>
        /// <returns></returns>
        public List<Models.DB.Activities> GetActivities()
        {
            try
            {
                var listActivities = new List<Logica.Models.DB.Activities>();

                connection = Data.ConnectionDB.GetConnection();
                command = new SqlCommand("SearchActivity", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                DataSet result = new DataSet();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(result);

                foreach (DataRow item in result.Tables[0].Rows)
                {
                    listActivities.Add(new Models.DB.Activities
                    {
                        Id = (int)item["Id"],
                        Name = (string)item["Name"],
                        Active = (bool?)item["Active"]
                    });
                }

                return listActivities;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<TypeServices> GetTypeServices()
        {
            try
            {
                var listTypeServices = new List<Logica.Models.DB.TypeServices>();

                connection = Data.ConnectionDB.GetConnection();
                command = new SqlCommand("GetTypeServices", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                DataSet result = new DataSet();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(result);

                foreach (DataRow item in result.Tables[0].Rows)
                {
                    listTypeServices.Add(new Models.DB.TypeServices
                    {
                        Id = (int)item["Id"],
                        Name = (string)item["Name"],
                        Active = (bool)item["Active"]
                    });
                }

                return listTypeServices;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateActivity(int id, string name, bool active)
        {
            throw new NotImplementedException();
        }
    }
}
