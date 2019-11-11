using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
   public class Users
    {

                     

        public void DeleteUsers(int? id)


        {
            ProjectMVC.DAL.Models.ProjectMVCEntities db = new ProjectMVC.DAL.Models.ProjectMVCEntities();

            var Users = db. Users.FirstOrDefault(x => x.Id == id);
            db. Users.Remove(Users);



            db.SaveChanges();

        }




    }
}
