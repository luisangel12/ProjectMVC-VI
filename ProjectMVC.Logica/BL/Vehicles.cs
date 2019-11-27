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
        /// <param name="Vehicles"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Models.DB.Vehicles> GetVehicles(/*string id,*/ /*int? customrtId*/)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            var listVehicles = (from _vehicles in _context.Vehicles
                                 
                                join _ClassVehicles in _context.ClassVehicles on _vehicles.ClassVehicleId equals _ClassVehicles.Id
                                join _TypeService in _context.TypeServices on _vehicles.TypeServiceId equals _TypeService.Id
                                       


                                select new Models.DB.Vehicles
                                {
                                    ClassVehicle = new Models.DB. ClassVehicle
                                    {
                                        Name = _ClassVehicles.Name

                                    },
                                    Id = _vehicles.Id,
                                    LicensePlate = _vehicles.LicensePlate,
                                    NroTransitLicense = _vehicles.NroTransitLicense,
                                    StateVehicle = _vehicles.StateVehicle,
                                    TypeServiceId = _vehicles.TypeServiceId,
                                    ClassVehicleId = _vehicles.ClassVehicleId,
                                    Image = _vehicles.Image,
                                    CustomerId = _vehicles.CustomerId,

                                }).ToList();

            //if (customrtId != null)
            //    listVehicles = listVehicles.Where(x => x.CustomerId == customrtId).ToList();

            //if (id != null)
            //    listVehicles = listVehicles.Where(x => x.Id.ToString() == id).ToList();
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
            int customerId)
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