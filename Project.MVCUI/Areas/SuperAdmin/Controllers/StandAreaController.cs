using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminRequestModels;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminResponseModels.SuperAdminPureVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperStandAreaPureVM = Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs.SuperStandAreaPureVM;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class StandAreaController : Controller
    {
        StandAreaRepository _saRep;
        public StandAreaController()
        {
            _saRep = new StandAreaRepository();
        }
        public ActionResult ListStandAreas(int? id)
        {
            List<SuperStandAreaPureVM> standAreas;
            if (id == null)
            {
                standAreas = _saRep.Select(x => new SuperStandAreaPureVM
                {
                    ID = x.ID,
                    StandAreaCode = x.StandAreaCode,
                    StandType = x.StandType,
                    Width = x.Width,
                    Height = x.Height,
                    M2Price = x.M2Price,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,

                }).ToList();
            }
            else
            {
                standAreas = _saRep.Select(x =>new SuperStandAreaPureVM
                {
                    ID = x.ID,
                    StandAreaCode = x.StandAreaCode,
                    StandType = x.StandType,
                    Width = x.Width,
                    Height = x.Height,
                    M2Price = x.M2Price,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();
            }
            ListStandAreaPageVM sapvm = new ListStandAreaPageVM
            {
                Areas = standAreas,
            };
            return View(sapvm);
        }
        public ActionResult AddStandArea()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStandArea(AddStandAreaRequestModel standArea)
        {
            if (ModelState.IsValid)
            {
                StandArea s1 = new StandArea
                {
                    StandAreaCode = standArea.StandAreaCode,
                    StandType = standArea.StandType,
                    Width = standArea.Width,
                    Height = standArea.Height,
                    M2Price = standArea.M2Price,
                    CreatedDate = DateTime.Now,
                };
                _saRep.Add(s1);
                return RedirectToAction("ListStandAreas");

            }
            else
            {
                return View(standArea);
            }
        }
        public ActionResult UpdateStandArea(int id)
        {
            StandArea selected = _saRep.Find(id);
            AddUpdateStandAreaPageVM sapvm = new AddUpdateStandAreaPageVM
            {
                StandArea = new UpdateStandAreaRequestModel
                {
                    ID = selected.ID,
                    StandAreaCode = selected.StandAreaCode,
                    StandType = selected.StandType,
                    Width = selected.Width,
                    Height = selected.Height,
                    M2Price = selected.M2Price,
                }

            };
            return View(sapvm);

        }
        [HttpPost]
        public ActionResult UpdateStandArea(UpdateStandAreaRequestModel standArea) 
        {
            if(ModelState.IsValid)
            {
                StandArea selected = _saRep.Find(standArea.ID);
                selected.StandAreaCode = standArea.StandAreaCode;
                selected.StandType = standArea.StandType;
                selected.Width = standArea.Width;
                selected.Height = standArea.Height;
                selected.M2Price = standArea.M2Price;
                _saRep.Update(selected);
                return RedirectToAction("ListStandAreas");
            }
            else
            {
                return View(standArea);
            }

           
        } 
         public ActionResult DeleteStandArea(int id)
         {
            _saRep.Delete(_saRep.Find(id));
             return RedirectToAction("ListStandAreas");
         }      

           
           





    }   
}