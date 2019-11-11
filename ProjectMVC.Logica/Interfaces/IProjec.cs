using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Interfaces
{
   public interface IProjec
    {
        List<Models.DB.Matches> GetMatches();
    }
}
