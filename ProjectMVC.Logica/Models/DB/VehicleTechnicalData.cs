using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class VehicleTechnicalData
    {
        public int? Id { get; set; }

        public bool CapacityLoad { get; set; }

        public int? PassengerCapacity { get; set; }

        public bool GVWR { get; set; }

        public int? CapacityPassengersSitting { get; set; }

        public int? NumberAxes { get; set; }

        public int? VehicleId { get; set; }
    }
}
