using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{


   



    public class Vehicles
    {

        public Vehicles()
        {


            //ClassVehicleId = new ClassVehicle();
            ClassVehicle = new ClassVehicle();

        }

        public int Id { get; set; }

        public string LicensePlate { get; set; }

        public string NroTransitLicense { get; set; }

        public bool? StateVehicle { get; set; }

        public int? ClassVehicleId { get; set; }

        public int? TypeServiceId { get; set; }
        public string Image { get; set; }

        public int? CustomerId { get; set; }




        public ClassVehicle ClassVehicle { get; set; }
        public TypeServices TypeService { get; set; }


    }
}
