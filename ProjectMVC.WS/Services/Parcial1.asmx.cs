using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectMVC.WS.Services
{
    /// <summary>
    /// Summary description for Parcial1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Parcial1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Logica.Models.DB.Matches> GetMatches()
        {
            var listActivities = new List<Logica.Models.DB.Matches>();

            Logica.Services.ProjecBD projecBD = new Logica.Services.ProjecBD();
            listActivities = projecBD.GetMatches();

            return listActivities;
        }
    }
}
