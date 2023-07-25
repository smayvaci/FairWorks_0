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
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: SuperAdmin/Employee
        EmployeeRepository _eRep;
        EmployeeRoleRepository _eRoleRep;
        public EmployeeController()
        {
            _eRep = new EmployeeRepository();
            _eRoleRep = new EmployeeRoleRepository();

        }
        private List<SuperEmployeePureVM> GetEmployee()
        {
            return _eRep.Select(e => new SuperEmployeePureVM
            {
                ID = e.ID,
                FirstName = e.FirstName,
                LastName = e.LastName,
                ContactNumber = e.ContactNumber,
                Address = e.Address,
                TrID = e.TrID,
                Email = e.Email,
                ReportTo = e.ReportTo,
                Password=e.Password,
                DataStatus = e.DataStatus.ToString(),
                CreatedDate = e.CreatedDate,
                UpdatedDate = e.UpdatedDate,
                DeletedDate = e.DeletedDate,

            }).ToList();
        }


        public ActionResult ListEmployees(int? id)
        {
            List<SuperEmployeePureVM> emp = GetEmployee();
            ListEmployeePageVM epm = new ListEmployeePageVM
            {
                Employees = emp,
            };
            _eRep.GetAll();
            return View(epm);
        }
        public ActionResult AddEmployee()
        {
            List<SuperEmployeeRolePureVM> emps = GetEmployeeRole();
            UpdateEmployeePageVM add = new UpdateEmployeePageVM
            {
                EmployeeRoles = emps
            };
            return View(add);
        }
        private List<SuperEmployeeRolePureVM> GetEmployeeRole()
        {
            return _eRoleRep.Select(x => new SuperEmployeeRolePureVM
            {
                ID = x.ID,
                TitleName = x.TitleName,
                Description = x.Description,
                Department = x.Department,

            }).ToList();

        }
        [HttpPost]
        public ActionResult AddEmployee(AddEmployeeRequestModel emp)
        {
            Employee employee = new Employee
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Email = emp.Email,
                ContactNumber = emp.ContactNumber,
                TrID = emp.TrID,
                ReportTo = emp.ReportTo,
                Address = emp.Address,
                UserName = emp.UserName,
                Password = emp.Password,
                CreatedDate = DateTime.Now,
            };
            _eRep.Add(employee);
            return RedirectToAction("ListEmployees");

        }
        public ActionResult UpdateEmployee(int id)
        {
            List<SuperEmployeeRolePureVM> employeeRoles = GetEmployeeRole();
            UpdateEmployeePageVM emp = new UpdateEmployeePageVM
            {
                EmployeeRoles = employeeRoles,
                Employee = _eRep.Where(x => x.ID == id).Select(x => new UpdateEmployeeRequestModel
                {
                    ID = x.ID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    ContactNumber = x.ContactNumber,
                    Address = x.Address,
                    ReportTo = x.ReportTo,
                    TrID = x.TrID,
                    UserName = x.UserName,
                    Password = x.Password,
                }).FirstOrDefault()
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(UpdateEmployeeRequestModel employee)
        {
            Employee employee1 = _eRep.Find(employee.ID);
            employee1.FirstName = employee.FirstName;
            employee1.LastName = employee.LastName;
            employee1.Email = employee.Email;
            employee1.ContactNumber = employee.ContactNumber;
            employee1.Address = employee.Address;
            employee1.ReportTo = employee.ReportTo;
            employee1.TrID = employee.TrID;
            employee1.UserName = employee.UserName;
            employee1.Password = employee.Password;
            _eRep.Update(employee1);
            return RedirectToAction("ListEmployees");

        }
        public ActionResult DeleteEmployee(int id)
        {
            _eRep.Delete(_eRep.Find(id));
            return View("ListEmployees");
        }
    }
}