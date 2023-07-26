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
        public ActionResult ListAdditionalServices(int? id)
        {
            List<SuperAdditionalServicePureVM> additionalservices;
            if (id == null)
            {
                additionalservices =_adRep.Select(x => new SuperAdditionalServicePureVM
                {
                    ID = x.ID,
                    TapWater = x.TapWater,
                    TapWaterPrice = x.TapWaterPrice,
                    WasteWater = x.WasteWater,
                    WasteWaterPrice = x.WasteWaterPrice,
                    Electricity = x.Electricity,
                    ElectricityPrice = x.ElectricityPrice,
                    SubTotalPrice = x.SubTotalPrice,
                    CompressedAir = x.CompressedAir,
                    CompressedAirPrice = x.CompressedAirPrice,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();
            }
            else
            {
                additionalservices =_adRep.Where(x=> x.ID==id).Select(x => new SuperAdditionalServicePureVM
                {
                    ID = x.ID,
                    TapWater = x.TapWater,
                    TapWaterPrice = x.TapWaterPrice,
                    WasteWater = x.WasteWater,
                    WasteWaterPrice = x.WasteWaterPrice,
                    Electricity = x.Electricity,
                    ElectricityPrice = x.ElectricityPrice,
                    SubTotalPrice = x.SubTotalPrice,
                    CompressedAir = x.CompressedAir,
                    CompressedAirPrice = x.CompressedAirPrice,
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
                AdditionalService x = new AdditionalService
                {
                   
                    TapWater = additionalservice.TapWater,
                    TapWaterPrice = additionalservice.TapWaterPrice,
                    WasteWater = additionalservice.WasteWater,
                    WasteWaterPrice = additionalservice.WasteWaterPrice,
                    Electricity = additionalservice.Electricity,
                    ElectricityPrice = additionalservice.ElectricityPrice,
                    SubTotalPrice = additionalservice.SubTotalPrice,
                    CompressedAir = additionalservice.CompressedAir,
                    CompressedAirPrice = additionalservice.CompressedAirPrice,
                    CreatedDate = DateTime.Now,
                };
                _adRep.Add(x);
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
                    TapWaterPrice = selected.TapWaterPrice,
                    WasteWater = selected.WasteWater,
                    WasteWaterPrice = selected.WasteWaterPrice,
                    Electricity = selected.Electricity,
                    ElectricityPrice = selected.ElectricityPrice,
                    SubTotalPrice = selected.SubTotalPrice,
                    CompressedAir = selected.CompressedAir,
                    CompressedAirPrice = selected.CompressedAirPrice,
    

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
                selected.TapWaterPrice = additionalservice.
                    TapWaterPrice;
                selected.WasteWater = additionalservice.WasteWater;
                selected.WasteWaterPrice = additionalservice.WasteWaterPrice;
                selected.Electricity = additionalservice.Electricity;
                selected.ElectricityPrice = additionalservice.ElectricityPrice;
                selected.CompressedAir = additionalservice.CompressedAir;
                selected.CompressedAirPrice = additionalservice.
                    CompressedAirPrice;
                selected.SubTotalPrice = additionalservice.SubTotalPrice;
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