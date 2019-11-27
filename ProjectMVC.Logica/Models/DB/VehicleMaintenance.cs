using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class VehicleMaintenance
    {
        public VehicleMaintenance()
        {
            Vehicles = new Vehicles();
            TypeMaintenance = new TypeMaintenance();
        }
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime MaintenanceDate { get; set; }

        public float CurrentMileage { get; set; }

        public DateTime NextMaintenanceDate { get; set; }

        public int TypeMaintenanceId { get; set; }

        public float Amount { get; set; }

        public int VehicleId { get; set; }


        public Vehicles Vehicles { get; set; }
        public TypeMaintenance TypeMaintenance { get; set; }
    }
}
