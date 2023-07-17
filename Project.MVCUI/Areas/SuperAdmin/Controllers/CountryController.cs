using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class CountryController : Controller
    {
        CountryRepository _cRep;
        public CountryController()
        {
            _cRep = new CountryRepository();
        }
        public ActionResult ListCountries(int? id)
        {
            List<SuperCountryPureVM> countries;
            if (id == null)
            {
                countries = _cRep.Select(x => new SuperCountryPureVM
                {
                    ID = x.ID,
                    CountryName = x.CountryName,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();

            }
            else
            {
                countries = _cRep.Select(x => new SuperCountryPureVM
                {
                    ID = x.ID, 
                    CountryName = x.CountryName,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();


            }
            ListCountryPageVM cpvm = new ListCountryPageVM
            {
                Countries = countries,
            };
            return View(cpvm);

        }
        public ActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCountry(AddCountryRequestModel country)
        {
            if (ModelState.IsValid)
            {
                Country c1 = new Country
                {
                    CountryName = country.CountryName,
                    CreatedDate = DateTime.Now,
                };
                _cRep.Add(c1);
                return RedirectToAction("ListCountries");

            }
            else
            {
                return View(country);
            }
        }
        public ActionResult UpdateCountry(int id)
        {
            Country selected = _cRep.Find(id);
            AddUpdateCountryPageVM cpvm = new AddUpdateCountryPageVM
            {
                Country = new UpdateCountryRequestModel
                {
                    ID = selected.ID,
                    CountryName = selected.CountryName,

                }

            };
            return View(cpvm);
        }
        [HttpPost]
        public ActionResult UpdateCountry(UpdateCountryRequestModel country)
        {
            if (ModelState.IsValid)
            {
                Country selected = _cRep.Find(country.ID);
                selected.CountryName = country.CountryName;
                _cRep.Update(selected);
                return RedirectToAction("ListCountries");
            }
            else
            {
                return View(country);
            }

        }
        public ActionResult DeleteCountry(int id)
        {
            _cRep.Delete(_cRep.Find(id));
            return RedirectToAction("ListCountries");
        }
    }
}