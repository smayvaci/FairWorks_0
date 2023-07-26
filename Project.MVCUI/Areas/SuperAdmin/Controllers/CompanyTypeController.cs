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
    public class CompanyTypeController : Controller
    {
        // GET: SuperAdmin/CompanyType
        CompanyTypeRepository _cTRep;
        public CompanyTypeController()
        {
            _cTRep = new CompanyTypeRepository();
        }
        public ActionResult ListCompanyTypes(int? id)
        {
            List<SuperCompanyTypePureVM> companyTypes;
            
            if (id==null)
            {
                companyTypes=_cTRep.Select(x=> new SuperCompanyTypePureVM
                { 
                    ID= x.ID,
                    CompanyTypeName = x.CompanyTypeName,
                    DataStatus=x.DataStatus.ToString(),
                    CreatedDate=x.CreatedDate,
                    UpdatedDate=x.UpdatedDate,
                    DeletedDate=x.DeletedDate,
                
                }).ToList();

            }
            else 
            {
                companyTypes = _cTRep.Where(X=> X.ID==id).Select(x => new SuperCompanyTypePureVM
                {
                    ID= x.ID,
                    CompanyTypeName = x.CompanyTypeName,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,

                }).ToList();
            }
            ListCompanyTypePageVM ctvm = new ListCompanyTypePageVM
            { 
                CompanyTypes = companyTypes,
            };
            return View(ctvm);
        
        }
        public ActionResult AddCompanyType()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult AddCompanyType(AddCompanyTypeRequestModel type)
        {
        
          
                CompanyType cT = new CompanyType
                {
                    CompanyTypeName= type.CompanyTypeName,
                    CreatedDate=DateTime.Now,
                };
                _cTRep.Add(cT);
                return RedirectToAction("ListCompanyTypes");
           

        }
        public ActionResult UpdateCompanyType(int id)
        {
            CompanyType selected = _cTRep.Find(id);
            UpdateCompanyTypesPageVM cpm = new UpdateCompanyTypesPageVM
            {
                CompanyType = new UpdateCompanyTypeRequestModel
                {
                    ID = selected.ID,
                    CompanyTypeName = selected.CompanyTypeName,
                }
            };
            return View(cpm);

        }
        [HttpPost]
        public ActionResult UpdateCompanyType(UpdateCompanyTypeRequestModel type)
        {
            //if (ModelState.IsValid)
          //  {
                CompanyType toBeUpdated = _cTRep.Find(type.ID);
                toBeUpdated.CompanyTypeName = type.CompanyTypeName;
                _cTRep.Add(toBeUpdated);
                return RedirectToAction("ListCompanyTypes");
          //  }
           // else
          //  {
          //      return View();
          //  }

        }

        public ActionResult DeleteCompanyType(int id)
        {
            _cTRep.Delete(_cTRep.Find(id));
            return RedirectToAction("ListCompanyTypes");
        
        }
    }
}