using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class Vehicles
    {
        /// <summary>
        /// GET VEHICLES
        /// </summary>
        /// <param name="VehicleId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Models.DB.Vehicles> GetVehicles()
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listVehicles = (from _vehicles in _context.Vehicles
                                    //join _states in _context.States on _vehicles.Sta equals _states.Id
                                    //join _activities in _context.Activities on _vehicles.ActivityId equals _activities.Id
                                    //join _priorities in _context.Priorities on _vehicles.PriorityId equals _priorities.Id
                                select new Models.DB.Vehicles
                                {
                                    //Id = _vehicles.Id,
                                    LicensePlate = _vehicles.LicensePlate,
                                    NroTransitLicense = _vehicles.NroTransitLicense,
                                    StateVehicle = _vehicles.StateVehicle,
                                    TypeServiceId = _vehicles.TypeServiceId,
                                    ClassVehicleId = _vehicles.ClassVehicleId,
                                    Image = _vehicles.Image,
                                    CustomerId = _vehicles.CustomerId,
                                   
                                }).ToList();

            //if (projectId != null)
            //    listTasks = listTasks.Where(x => x.ProjectId == projectId).ToList();
            //if (id != null)
            //    listTasks = listTasks.Where(x => x.Id == id).ToList();

            return listVehicles;
        }

        /// <summary>
        /// CREATE TASKS
        /// </summary>
        /// <param name="id"></param>
        /// <param name="licensePlate"></param>
        /// <param name="nroTransitLicense"></param>
        /// <param name="stateVehicle"></param>
        /// <param name="trypeServiceId"></param>
        /// <param name="classVehicleId"></param>
        /// <param name="image"></param>
        /// <param name="customerId"></param>
        public void CreateVehicles(int id,
            string licensePlate,
            string nroTransitLicense,
            bool stateVehicle,
            int? trypeServiceId,
            int? classVehicleId,
            string image,
            int? customerId)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            _context.Vehicles.Add(new DAL.Models.Vehicle
            {
                //Id = id,
                LicensePlate = licensePlate,
                NroTransitLicense = nroTransitLicense,
                StateVehicle = stateVehicle,
                TypeServiceId = trypeServiceId,
                ClassVehicleId = classVehicleId,
                Image = image,
                CustomerId = customerId
            });

            _context.SaveChanges();
        }
    }
}
