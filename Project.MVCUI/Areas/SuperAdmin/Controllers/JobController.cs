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
    public class JobController : Controller
    {
        // GET: SuperAdmin/Job
        JobRepository _jRep;
        public JobController()
        {
            _jRep = new JobRepository();
        }
        public ActionResult ListJobs(int? id)
        {
            List<SuperJobPureVM> jobs;
            if (id == null) 
            {
                jobs = _jRep.Select(x => new SuperJobPureVM
                {
                    ID = x.ID,
                    Name = x.JobName,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();
            }
            else
            {
                jobs =_jRep.Where(x=>x.ID==id).Select(x => new SuperJobPureVM
                {
                    ID = x.ID,
                    Name = x.JobName,
                    DataStatus = x.DataStatus.ToString(),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    DeletedDate = x.DeletedDate,
                }).ToList();
            }
            ListJobPageVM jpvm = new ListJobPageVM
            {
                Jobs = jobs,
            };
            return View(jpvm);
        }
        public ActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJob(AddJobRequestModel job)
        {
            if(ModelState.IsValid)
            {
                Job j1 = new Job
                {
                    JobName = job.JobName,
                    CreatedDate = DateTime.Now,
                };
                _jRep.Add(j1);
                return RedirectToAction("ListJobs");
            }
            else
            {
                return View(job);
            }
        }
        public ActionResult UpdateJob(int id)
        {
            Job selected = _jRep.Find(id);
            UpdateJobPageVM jpvm = new UpdateJobPageVM
            {
                Job = new UpdateJobRequestModel
                {
                    ID = selected.ID,
                    JobName = selected.JobName,
                }    
            };
            return View(jpvm);  
        }
        [HttpPost]
        public ActionResult UpdateJob(UpdateJobRequestModel job)
        {
            if (ModelState.IsValid)
            {
                Job selected = _jRep.Find(job.ID);
                selected.JobName = job.JobName;
                _jRep.Add(selected);
                return RedirectToAction("ListJobs");
            }
            else
            {
                return View(job);
            }
        }
        public ActionResult DeleteJob(int id)
        {
            _jRep.Delete(_jRep.Find(id));
            return RedirectToAction("ListJobs");

        }
    }
}