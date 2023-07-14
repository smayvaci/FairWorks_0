using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    //[RouteArea("SuperAdmin")]
    public class CompanyController : Controller
    {
        CompanyRepository _cRep; // şirket
        SectorRepository _sRep; // sektör
        CountryRepository _cnrtyRep; // ülke
        CompanyTypeRepository _cTRep;  //şirket tipi
        public CompanyController()
        {
            _cnrtyRep = new CountryRepository();
            _sRep = new SectorRepository();
            _cTRep = new CompanyTypeRepository();
            _cRep = new CompanyRepository();
        }
        private List<SuperCompanyPureVM> GetCompanies()
        {
            return _cRep.Select(c => new SuperCompanyPureVM
            {
                ID = c.ID,
                CreatedDate = c.CreatedDate,
                UpdatedDate = c.UpdatedDate,
                DeletedDate = c.DeletedDate,
                DataStatus = c.DataStatus.ToString(),
                CompanyName = c.CompanyName,
                PhoneNumber = c.PhoneNumber,
                EMail = c.EMail,
                Address = c.Address,
                City = c.City,

            }).ToList();
        }
        private List<SuperCompanyTypePureVM> GetCompaniesTypes()
        {
            return _cTRep.Select(t => new SuperCompanyTypePureVM
            {
                ID = t.ID,
                CompanyTypeName = t.CompanyTypeName,

            }).ToList();
        }
        private List<SuperCountryPureVM> GetCountries()
        {
            return _cnrtyRep.Select(con => new SuperCountryPureVM
            {
                ID = con.ID,
                CountryName = con.CountryName,

            }).ToList();
        }
        private List<SuperSectorPureVM> GetSectors()
        {
            return _sRep.Select(s => new SuperSectorPureVM
            {
                ID = s.ID,
                SectorName = s.SectorName,
            }).ToList();

        }
       
        public ActionResult ListCompanies(int? id)
        {
            List<SuperCompanyPureVM> com = GetCompanies();
            List<SuperCompanyTypePureVM> CompanyTypes = GetCompaniesTypes();
            List<SuperCountryPureVM> countries = GetCountries();
            List<SuperSectorPureVM> sectors= GetSectors();
            ListCompanyPageVM cpm = new ListCompanyPageVM
            {
                Companies = com,
                CompanyTypes = CompanyTypes,
                Countries = countries,
                Sectors = sectors,
            };
            _cRep.GetAll();
            return View(cpm);
        }
        public ActionResult AddCompany()
        {
            List<SuperCompanyTypePureVM> CompanyTypes = GetCompaniesTypes();
            List<SuperCountryPureVM> countries = GetCountries();
            List<SuperSectorPureVM> sectors = GetSectors();
            AddUpdateCompanyPageVM add = new AddUpdateCompanyPageVM
            {
                CompanyTypes = CompanyTypes,
                Sectors = sectors,
                Countries = countries,
            };

            return View(add);
        }
        [HttpPost]
        public ActionResult AddCompany(SuperCompanyPureVM company)
        {


            return RedirectToAction("ListCompanies");
        }
    }
}