using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class RoleController : Controller
    {
        EmployeeRoleRepository _rRep;
        public RoleController()
        {
            _rRep = new EmployeeRoleRepository();
        }
        public ActionResult ListRoles(int? id)
        {
            List<SuperEmployeeRolePureVM> eRoles;
            if (id == null)
            {
                eRoles = _rRep.Select(x => new SuperEmployeeRolePureVM
                {
                    ID = x.ID,
                    TitleName = x.TitleName,
                    Department = x.Department,
                    Description = x.Description,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus = x.DataStatus.ToString(),


                }).ToList();
            }
            else
            {
                eRoles = _rRep.Where(x => x.ID == id).Select(x => new SuperEmployeeRolePureVM
                {
                    ID = x.ID,
                    TitleName = x.TitleName,
                    Department = x.Department,
                    Description = x.Description,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus = x.DataStatus.ToString(),


                }).ToList();
            }
            ListEmployeeRolePageVM epm = new ListEmployeeRolePageVM
            {
                EmployeeRoles = eRoles,
            };
            return View(epm);
        }
        public ActionResult AddEmployeeRole()
        { 
             return View();
        
        }
        [HttpPost]
        public ActionResult AddEmployeeRole(AddEmployeeRoleRequestModel eRole) 
        {
            EmployeeRole r = new EmployeeRole 
            {
                TitleName = eRole.TitleName,
                Department=eRole.Department,
                Description = eRole.Description,
            };
            _rRep.Add(r);
            return RedirectToAction("ListRoles");
        
        }
    }
}