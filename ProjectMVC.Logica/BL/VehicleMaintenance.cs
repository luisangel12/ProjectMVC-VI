using System;

namespace ProjectMVC.Logica.BL
{
    public class VehicleMaintenance
    {
        /// <summary>
        /// CREATE TASKS
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="MaintenanceDate"></param>
        /// <param name="CurrentMileage"></param>
        /// <param name="NextMaintenanceDate"></param>
        /// <param name="TypeMaintenanceId"></param>
        /// <param name="Amount"></param>
        /// <param name="VehicleId"></param>

        public void CreateVehicleMantenimiento(int id,
            string Description,
             DateTime? MaintenanceDate,
             double? CurrentMileage,
             DateTime? NextMaintenanceDate,
             int? TypeMaintenanceId,
             double? Amount,
             int? VehicleId)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            _context.VehicleMaintenances.Add(new DAL.Models.VehicleMaintenance
            {
                //Id = id,
                Description = Description,
                MaintenanceDate = MaintenanceDate,
                CurrentMileage = CurrentMileage,
                NextMaintenanceDate = NextMaintenanceDate,
                TypeMaintenanceId = TypeMaintenanceId,
                Amount = Amount,
                VehicleId = VehicleId
            });

            _context.SaveChanges();
        }
    }
}