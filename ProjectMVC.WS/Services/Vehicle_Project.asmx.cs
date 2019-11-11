using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectMVC.WS.Services
{
    /// <summary>
    /// Summary description for Vehicle_Project
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Vehicle_Project : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Logica.Models.DB.TypeServices> GetTypeServices()
        {
            var listTypeServices = new List<Logica.Models.DB.TypeServices>();

            Logica.Services.Activities TypeServices = new Logica.Services.Activities();
            listTypeServices = TypeServices.GetTypeServices();

            return listTypeServices;
        }

        [WebMethod]
        public List<Logica.Models.DB.Vehicles> GetVehicles()
        {
            var listVehicles = new List<Logica.Models.DB.Vehicles>();

            Logica.Services.Vehicle_Projectcs Vehicles = new Logica.Services.Vehicle_Projectcs();
            listVehicles = Vehicles.GetVehicles();

            return listVehicles;
        }

    }
}
