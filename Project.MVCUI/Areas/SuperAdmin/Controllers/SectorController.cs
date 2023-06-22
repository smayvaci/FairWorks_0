using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPageVMs;
using Project.MVCUI.Areas.SuperAdmin.Data.SuperAdminPureVMs;
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
        public ActionResult Index()
        {
            return View();
        }
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
                sectors=_sRep.Where(x=>x.ID==id).Select(x=> new SuperSectorPureVM 
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

    }
}