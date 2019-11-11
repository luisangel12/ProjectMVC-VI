using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class VehicleGeneralInformation
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public string Line { get; set; }

        public int Model { get; set; }

        public string Color { get; set; }

        public string SerialNumber { get; set; }

        public string EngineNumber { get; set; }

        public string ChassisNumber { get; set; }

        public string VIN { get; set; }

        public int Cylinder { get; set; }

        public string TypeBody { get; set; }

        public int TypeFuelId { get; set; }

        public DateTime InitialEnrollmentDate { get; set; }

        public int NroDoors { get; set; }

        public int TypeTireId { get; set; }

        public int AuthoritiesTransitId { get; set; }

        public int VehicleId { get; set; }
    }
}
