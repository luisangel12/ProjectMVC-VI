using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class VehicleFuels
    {
      
        public int TypeFuelId { get; set; }

        public float Amount { get; set; }

        public float? LiterFuel { get; set; }      

        public int? VehicleId { get; set; }

    }
}
