using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.ListPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs.UpdatePageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
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
    public class FairController : Controller
    {
        FairRepository _fRep;
        public FairController()
        {
            _fRep = new FairRepository();
        }
        // GET: SuperAdmin/Fair
        public ActionResult ListFairs(int? id)
        {
            List<SuperFairPureVM> fairs;
            if (id == null)
            {
                fairs= _fRep.Select(x => new SuperFairPureVM
                {
                    ID = x.ID,
                    EntranceDoor = x.EntranceDoor,
                    ExitDoor = x.ExitDoor,
                    StartDate = x.StartDate,
                    ExpiryDate = x.ExpiryDate,
                    Location = x.Location,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus=x.DataStatus.ToString(),

                }).ToList();
            }
            else
            {
                fairs = _fRep.Where(x=>x.ID==id).Select(x => new SuperFairPureVM
                {
                    ID = x.ID,
                    EntranceDoor = x.EntranceDoor,
                    ExitDoor = x.ExitDoor,
                    StartDate = x.StartDate,
                    ExpiryDate = x.ExpiryDate,
                    Location = x.Location,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus=x.DataStatus.ToString(),

                }).ToList();
            }
            ListFairPageVM fpvm = new ListFairPageVM
            {
                Fairs = fairs,
            };
            return View(fpvm);
        }
        public ActionResult AddFair()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFair(AddFairRequestModel fair)
        {
            if (ModelState.IsValid)
            {
                Fair f = new Fair
                {
                    EntranceDoor = fair.EntranceDoor,
                    ExitDoor = fair.ExitDoor,
                    StartDate = fair.StartDate,
                    ExpiryDate = fair.ExpiryDate,
                    Location = fair.Location,
                    CreatedDate = DateTime.Now,
                };
                _fRep.Add(f);
                return RedirectToAction("ListFairs");

            }
            else
            {
                return View(fair);
            }
        }
        public ActionResult UpdateFair(int id)
        {
            Fair selected = _fRep.Find(id);
            UpdateFairPageVM f = new UpdateFairPageVM
            {
                Fair = new UpdateFairRequestModel
                {
                    ID = selected.ID,
                    EntranceDoor = selected.EntranceDoor,
                    ExitDoor = selected.ExitDoor,
                    StartDate = selected.StartDate,
                    ExpiryDate = selected.ExpiryDate,
                    Location = selected.Location,
                }
            };
            return View(f);
        }
        [HttpPost]
        public ActionResult UpdateFair(UpdateFairRequestModel fair)
        {
            if (ModelState.IsValid)
            {
                Fair toBeUpdated = _fRep.Find(fair.ID);
                toBeUpdated.EntranceDoor = fair.EntranceDoor;
                toBeUpdated.ExitDoor = fair.ExitDoor;
                toBeUpdated.StartDate = fair.StartDate;
                toBeUpdated.ExpiryDate = fair.ExpiryDate;
                toBeUpdated.Location = fair.Location;
                _fRep.Update(toBeUpdated);
                return RedirectToAction("ListFairs");

            }
            else
            {
                return View(fair);
            }

        }
        public ActionResult DeleteFair(int id)
        {
            _fRep.Delete(_fRep.Find(id));
            return RedirectToAction("ListFairs");
        }
    }
}


   