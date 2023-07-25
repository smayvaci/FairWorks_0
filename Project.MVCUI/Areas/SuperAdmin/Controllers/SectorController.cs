using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
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
    public class SectorController : Controller
    {
        SectorRepository _sRep;
        public SectorController()
        {
            _sRep = new SectorRepository();
        }
        // GET: SuperAdmin/Sector
        public ActionResult ListSectors(int? id)
        {
            List<SuperSectorPureVM> sectors;
            if (id==null)
            {
                sectors=_sRep.Select(x=> new SuperSectorPureVM
                { 
                    ID = x.ID,
                    SectorName = x.SectorName,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus=x.DataStatus.ToString(),
                }).ToList();
            }
            else 
            {
                sectors = _sRep.Select(x=> new SuperSectorPureVM 
                {
                    ID = x.ID,
                    SectorName = x.SectorName,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus = x.DataStatus.ToString(),

                }).ToList();
            }
            ListSectorPageVM spvm = new ListSectorPageVM
            { 
                Sectors = sectors,
            };
            return View(spvm);
        
        }
        public ActionResult AddSector()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult AddSector(AddSectorRequestModel sector)
        {
            if (ModelState.IsValid)// validasyonu bu şekilde kontrol ediyoruz.
            {
                Sector sec = new Sector
                {
                    SectorName = sector.SectorName,
                    CreatedDate = DateTime.Now
                };

                _sRep.Add(sec);
                return RedirectToAction("ListSectors");
            }
            else
            {
                return View(sector); // Validasyon hatası varsa diye.
                //todo redirecttoaction dene
            }
        }

        public ActionResult UpdateSector(int id)
        {
            Sector selected = _sRep.Find(id);
            UpdateSectorPageVM sec = new UpdateSectorPageVM
            { 
                Sector= new UpdateSectorRequestModel 
                {
                    ID= selected.ID,
                    SectorName= selected.SectorName,
                    
                }
            
            };
            return View(sec);
        }
        [HttpPost]
        public ActionResult UpdateSector(UpdateSectorRequestModel sector)
        {
            if (ModelState.IsValid)// updaterequest modelde yazmış olduğum validationlar için kontroller buradan sağlanıyor
            {
                Sector toBeUpdated = _sRep.Find(sector.ID);
                toBeUpdated.SectorName = sector.SectorName;
                _sRep.Update(toBeUpdated);
                return RedirectToAction("ListSectors");
            }
            else
            {
                return View(sector); // Validasyon hatası varsa aynı sayfaya dönüş
            }
        }
        public ActionResult DeleteSector(int id)
        {
            _sRep.Delete(_sRep.Find(id));
            return RedirectToAction("ListSectors");
        }
    }
}