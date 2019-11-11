using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class VehiclePolicySOAT
    {
        public int Id { get; set; }

        public string PolicyNumber { get; set; }

        public DateTime ExpeditionDater { get; set; }

        public DateTime DateStartValidity { get; set; }

        public DateTime EndDateValidity { get; set; }

        public string SOATIssueEntity { get; set; }

        public int State { get; set; }

        public int VehicleId { get; set; }
    }
}
