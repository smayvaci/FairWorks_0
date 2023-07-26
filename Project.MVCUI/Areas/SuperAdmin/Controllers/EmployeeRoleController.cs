using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class EmployeeRoleController : Controller
    {
        EmployeeRoleRepository _eRoleRep;
        public EmployeeRoleController()
        {
            _eRoleRep = new EmployeeRoleRepository();
        }
        public ActionResult ListEmployeeRoles(int? id)
        {
            List<SuperEmployeeRolePureVM> eRoles;
            if (id == null) 
            {
                eRoles=_eRoleRep.Select(x=> new SuperEmployeeRolePureVM  
                { 
                    ID=x.ID,
                    TitleName = x.TitleName,
                    Department=x.Department,
                    Description = x.Description,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus=x.DataStatus.ToString(),
                
                
                }).ToList();
            }
            else 
            {
                eRoles = _eRoleRep.Where(x=>x.ID==id).Select(x => new SuperEmployeeRolePureVM
                {
                    ID=x.ID,
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
            EmployeeRole eRole1 = new EmployeeRole
            {
                TitleName = eRole.TitleName,
                Department = eRole.Department,
                Description = eRole.Description,
            };
            _eRoleRep.Add(eRole1);
            return RedirectToAction("ListEmployeeRoles");
        }
        public ActionResult UpdateEmployeeRole(int id)
        { 
            EmployeeRole selected=_eRoleRep.Find(id);
            UpdateEmployeeRolePageVM epm = new UpdateEmployeeRolePageVM
            { 
                EmployeeRole=new UpdateEmployeeRoleRequestModel
                { 
                    ID=selected.ID,
                    TitleName=selected.TitleName,
                    Department=selected.Department,
                    Description=selected.Description,
                }
            };
            return View(epm);
        }
        [HttpPost]
        public ActionResult UpdateEmployeeRole(UpdateEmployeeRoleRequestModel eRole)
        {
            EmployeeRole selected = _eRoleRep.Find(eRole.ID);
            selected.TitleName = eRole.TitleName;
            selected.Description = eRole.Description;
            selected.Department = eRole.Department;
            _eRoleRep.Update(selected);
            return RedirectToAction("ListEmployeeRoles");
        }
        public ActionResult DeleteEmployeeRole(int id) 
        {
            _eRoleRep.Delete(_eRoleRep.Find(id));
            return RedirectToAction("ListEmployeeRoles");
        }
    }
}