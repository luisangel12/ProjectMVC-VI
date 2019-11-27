using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class VehicleGeneralInformation
    {
        public void CreateVehicleGeneralInformation(/*int id,*/
            int? BrandId,
            string Line,
            int? Model,
            string Color,
            string SerialNumber,
            string EngineNumber,
            string ChassisNumber,
            string VIN,
            int? Cylinder,
            string TypeBody,
            int? TypeFuelId,
            DateTime? InitialEnrollmentDate,
            int? NroDoors,
            int? TypeTireId,
            int? AuthoritiesTransitId,
            int? VehicleId)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            _context.VehicleGeneralInformations.Add(new DAL.Models.VehicleGeneralInformation
            {
                //Id = id,
                BrandId = BrandId,
                Line = Line,
                Model = Model,
                Color = Color,
                SerialNumber = SerialNumber,
                EngineNumber = EngineNumber,
                ChassisNumber = ChassisNumber,
                VIN = VIN,
                Cylinder = Cylinder,
                TypeBody = TypeBody,
                TypeFuelId = TypeFuelId,
                InitialEnrollmentDate = InitialEnrollmentDate,
                NroDoors = NroDoors,
                TypeTireId = TypeTireId,
                AuthoritiesTransitId = AuthoritiesTransitId,
                VehicleId = VehicleId
            });

            _context.SaveChanges();
        }
    }
}
