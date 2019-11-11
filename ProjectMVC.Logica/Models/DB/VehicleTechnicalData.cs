using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class VehicleTechnicalData
    {
        public int Id { get; set; }

        public int CapacityLoad { get; set; }

        public float PassengerCapacity { get; set; }

        public float GVWR { get; set; }

        public int CapacityPassengersSitting { get; set; }

        public int NumberAxes { get; set; }

        public int VehicleId { get; set; }
    }
}
