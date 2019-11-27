using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class VehicleFuels
    {

        #region MyRegion
        //public List<Models.DB.Projects> GetProjects(int? id,
        //    int? tenantId,
        //    string userId = null)
        //{
        //    DAL.Models.ProjectMVCEntities2 db = new DAL.Models.ProjectMVCEntities2();

        //    var listProjectsEF = (from _projects in db.Projects
        //                          select _projects);

        //    if (id != null)
        //        listProjectsEF = listProjectsEF.Where(x => x.Id == id);
        //    if (tenantId != null)
        //        listProjectsEF = listProjectsEF.Where(x => x.TenantId == tenantId);
        //    if (!string.IsNullOrEmpty(userId))
        //        listProjectsEF = (from _projects in listProjectsEF
        //                          join _userProjects in db.UserProjects on _projects.Id equals _userProjects.ProjectId
        //                          where _userProjects.Id.Equals(userId)
        //                          select _projects);

        //    var listProjects = (from _projects in listProjectsEF
        //                        select new Models.DB.Projects
        //                        {
        //                            Id = _projects.Id,
        //                            Title = _projects.Title,
        //                            Details = _projects.Details,
        //                            ExpectedCompletionDate = _projects.ExpectedCompletionDate,
        //                            TenantId = _projects.TenantId,
        //                            CreatedAt = _projects.CreatedAt,
        //                            UpdatedAt = _projects.UpdatedAt
        //                        }).ToList();

        //    return listProjects;
        //} 
        #endregion


        public void CreateVehicleFuel(int TypeFuelId,
            double Amount,
            double? LiterFuel,
            int? VehicleId)
        {
            DAL.Models.ProjectMVCEntities2 _context = new DAL.Models.ProjectMVCEntities2();

            _context.VehicleFuels.Add(new DAL.Models.VehicleFuel
            {
                TypeFuelId = TypeFuelId,
                Amount = Amount,
                LiterFuel = LiterFuel,
                FuelDate = DateTime.Now,
                VehicleId = VehicleId
            });

            _context.SaveChanges();            
        }


        #region MyRegion
        //public void UpdateProjects(int id,
        //    string title,
        //    string details,
        //    DateTime? expectedCompletionDate)
        //{
        //    DAL.Models.ProjectMVCEntities2 db = new DAL.Models.ProjectMVCEntities2();

        //    var project = db.Projects.FirstOrDefault(x => x.Id == id);

        //    project.Title = title;
        //    project.Details = details;
        //    project.ExpectedCompletionDate = expectedCompletionDate;
        //    project.UpdatedAt = DateTime.Now;

        //    db.SaveChanges();
        //}


        //public void DeleteProjects(int? id)
        //{
        //    DAL.Models.ProjectMVCEntities2 db = new DAL.Models.ProjectMVCEntities2();

        //    var project = db.Projects.FirstOrDefault(x => x.Id == id);
        //    db.Projects.Remove(project);

        //    db.SaveChanges();
        //} 
        #endregion
    }
}
