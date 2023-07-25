using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
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

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class HallController : Controller
    {
        HallRepository _hRep;
        public HallController()
        {
            _hRep = new HallRepository();
        }
        // GET: SuperAdmin/Hall
        public ActionResult ListHalls(int? id)
        {
            List<SuperHallPureVM> halls;
            if (id == null)
            {
                halls = _hRep.Select(x => new SuperHallPureVM
                {
                    ID = x.ID,
                    HallNumber = x.HallNumber,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus=x.DataStatus.ToString()
                }).ToList();
            }
            else
            {
                halls = _hRep.Where(x=>x.ID==id).Select(x => new SuperHallPureVM
                {
                    ID = x.ID,
                    HallNumber = x.HallNumber,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                    DataStatus=x.DataStatus.ToString()
                }).ToList();
                
            }
          
            return View(halls);
        }

    }
}