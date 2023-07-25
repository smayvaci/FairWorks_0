using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.AddRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels.UpdateRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using Project.VM.PureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class AdditionalServiceController : Controller
    {
        // GET: SuperAdmin/AdditionalService
        AdditionalServiceRepository _adRep;
        public AdditionalServiceController()
        {
            _adRep = new AdditionalServiceRepository();
        }
        public ActionResult ListAdditionalService(int? id)
        {
            List<SuperAdditionalServicePureVM> additionalservices;
            if (id == null)
            {
                additionalservices =_adRep.Select(x => new SuperAdditionalServicePureVM
                {
                    ID = x.ID,
                    TapWater = x.TapWater,
                    WasteWater = x.WasteWater,
                    Electricity = x.Electricity,
                    ExtraPrice = x.ExtraPrice,
                    CompressedAir = x.CompressedAir,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();
            }
            else
            {
                additionalservices =_adRep.Select(x => new SuperAdditionalServicePureVM
                {   ID = x.ID,
                    TapWater = x.TapWater,
                    WasteWater = x.WasteWater,
                    Electricity = x.Electricity,
                    ExtraPrice = x.ExtraPrice,
                    CompressedAir = x.CompressedAir,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();


            }
            ListAdditionalServicePageVM adpvm = new ListAdditionalServicePageVM
            {
                AdditionalServices = additionalservices,
            };
            return View(adpvm);

        }
        public ActionResult AddAdditionalService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdditionalService(AddAdditionalServiceRequestModel additionalservice)
        {
            if (ModelState.IsValid)
            {
                AdditionalService ad1 = new AdditionalService
                {
                    TapWater = additionalservice.TapWater,
                    WasteWater= additionalservice.WasteWater,
                    Electricity= additionalservice.Electricity,
                    ExtraPrice = additionalservice.ExtraPrice,
                    CompressedAir = additionalservice.CompressedAir,
                    CreatedDate = DateTime.Now,
                };
                _adRep.Add(ad1);
                return RedirectToAction("ListAdditionalServices");
            }
            else
            {
                return View(additionalservice);
            }
        }
        public ActionResult UpdateAdditionalService(int id)
        {
            AdditionalService selected = _adRep.Find(id);
            UpdateAdditionalServicePageVM adpvm = new UpdateAdditionalServicePageVM
            {
                AdditionalService = new UpdateAdditionalServiceRequestModel
                {
                    ID = selected.ID,
                    TapWater = selected.TapWater,
                    WasteWater= selected.WasteWater,
                    Electricity= selected.Electricity,
                    ExtraPrice = selected.ExtraPrice,
                    CompressedAir = selected.CompressedAir,

                }
            };
             return View(adpvm);   
        }
        [HttpPost]
        public ActionResult UpdateAdditionalService(UpdateAdditionalServiceRequestModel additionalservice) 
        {
            if (ModelState.IsValid)
            {
               AdditionalService selected = _adRep.Find(additionalservice.ID);
                selected.TapWater = additionalservice.TapWater;
                selected.WasteWater = additionalservice.WasteWater;
                selected.Electricity = additionalservice.Electricity;
                selected.ExtraPrice = additionalservice.ExtraPrice;
                selected.CompressedAir = additionalservice.CompressedAir;
                _adRep.Update(selected);
                return RedirectToAction("ListAdditionalServices");

            }
            else
            {
                return View(additionalservice);
            }
        }
        public ActionResult DeleteAdditionalService(int id)
        {
            _adRep.Delete(_adRep.Find(id));
            return RedirectToAction("ListAdditionalServices");
        }

    }
    
}