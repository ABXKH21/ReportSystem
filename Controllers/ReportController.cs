using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportSystem.Context;
using ReportSystem.Models;
using ReportSystem.Repo;
using ReportSystem.ViewModels.ReportViewModel;
using System;
using System.Linq;

namespace ReportSystem.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _report;
        private readonly INationalitiesRepository _nationalities;
        private readonly IAddressesRepository _addresses;
        private readonly ICategoriesRepository _categories;


        private readonly ReportSysContext _context;

        public ReportController(IReportRepository report,
            INationalitiesRepository nationalities,
            IAddressesRepository addresses,
            ICategoriesRepository categories, ReportSysContext context)
        {
            _report = report;
            _nationalities = nationalities;
            _addresses = addresses;
            _categories = categories;
            _context = context;
        }


        // GET: ReportController1
        /*[Authentication]*/
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "InformantName")
            {
                return View(_context.Report.Where(x => x.InformantName == search).ToList());
            }
            else
                return View(_report.GetAllReports());
        }

        // GET: ReportController1/Details/5
        public ActionResult Details(int id)
        {                 
            try
            {                
                //var result = _context.Report .Where(c => c.ReportID == id) .FirstOrDefault();
                var result = _report.GetReport(id);
                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }

        public ActionResult GetSubCat(int mainCatId)
        {
            return Ok(_categories.GetAllSubCategories(mainCatId));
        }

        public ActionResult GetProcedureType(int subCatId)
        {
            return Ok(_categories.GetAllProceduerTypes(subCatId));
        }

      

        // GET: ReportController1/Create
        public ActionResult Create(int id)
        {
            CreationReport newReport = new CreationReport
            {
                MainCategories = _categories.GetAllMainCategories(),
                Nationalities = _nationalities.GetAllNationalities(),
                Districts = _addresses.GetAllDistricts(),
            };
            return View(newReport);
        }


        // POST: ReportController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreationReport report)
        {          
            try
            {
                //if (ModelState.IsValid == true)
                //{                
                Report newReport = new Report
                {
                    //CreationReportDate = DateTime.Now,
                    //CreationReportTime = DateTime.Now,
                    ReportID = report.ReportID,
                    CreationReportDate = report.CreationReportDate,
                    CreationReportTime = report.CreationReportTime,
                    Entrance = report.Entrance,
                    Bulding = report.Bulding,
                    InformantID = report.InformantID,
                    InformantName = report.InformantName,
                    Mobile = report.Mobile,
                    Gender = report.Gender,
                    Status = report.Status,
                    Summary = report.Summary,
                    AccidentCause = report.AccidentCause,
                    LocationDescriptin = report.LocationDescriptin,
                    ProcedureTypesId = report.ProceduerTypeID,
                    DistrictsID = report.DistrictsID,
                    //ByStreetsID = report.ByStreetsID,
                    NationalitiesID = report.NationalitiesID,
                    //CreatorUserame = report.CreatorUserame                    
                    CreatorUserame = User.Identity.Name!,
                    //CreatorUserame = HttpContext.Session.GetString("UserName"),
                };

                _report.AddReport(newReport);
                TempData["SuccessCreate"] = "Saved successfully";
                return RedirectToAction(nameof(Index));
                //}

                /*  report.MainCategories = _categories.GetAllMainCategories();
                  report.Nationalities = _nationalities.GetAllNationalities();
                  report.Districts = _addresses.GetAllDistricts();
                  return View(report);*/
            }
            catch (Exception ex)
            {
                report.MainCategories = _categories.GetAllMainCategories();
                report.Nationalities = _nationalities.GetAllNationalities();
                report.Districts = _addresses.GetAllDistricts();  
                ViewBag.ErrorMessage = ex;
                return View(report);
            }
        }



        // GET: ReportController1/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var result = _context.Report.Where(c => c.ReportID == id).FirstOrDefault();
                CreationReport editReport = new CreationReport
                {
                    ReportID = result.ReportID,
                    MainCategories = _categories.GetAllMainCategories(),
                    SubCategories = _categories.GetAllSubCategories(result.ProcedureTypesId),
                    Nationalities = _nationalities.GetAllNationalities(),
                    Districts = _addresses.GetAllDistricts(),
                    CreationReportDate = result.CreationReportDate,
                    CreationReportTime = result.CreationReportTime,
                    Entrance = result.Entrance,
                    Bulding = result.Bulding,
                    InformantID = result.InformantID,
                    InformantName = result.InformantName,
                    Mobile = result.Mobile,
                    Gender = result.Gender,
                    Status = result.Status,
                    Summary = result.Summary,
                    AccidentCause = result.AccidentCause,
                    LocationDescriptin = result.LocationDescriptin,
                    ProceduerTypeID = result.ProcedureTypesId,
                    //ByStreetsID = result.ByStreetsID,
                    NationalitiesID = result.NationalitiesID,
                    ProceduerTypeName = _categories.GetProceduerTypeName(result.ProcedureTypesId).ProcedureTypeName,
                };
                return View(editReport);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }

        // POST: ReportController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CreationReport creationReport)
        {
            try
            {              
                //if (ModelState.IsValid == true)
                //{
                    Report report  = _report.FindInReport(creationReport.ReportID);
                    if (report != null)
                    {
                        report.ReportID = creationReport.ReportID;
                        report.CreationReportDate = creationReport.CreationReportDate;
                        report.CreationReportTime = creationReport.CreationReportTime;
                        report.Entrance = creationReport.Entrance;
                        report.Bulding = creationReport.Bulding;
                        report.InformantID = creationReport.InformantID;
                        report.InformantName = creationReport.InformantName;
                        report.Mobile = creationReport.Mobile;
                        report.Gender = creationReport.Gender;
                        report.Status = creationReport.Status;
                        report.Summary = creationReport.Summary;
                        report.DistrictsID = creationReport.DistrictsID;
                        report.AccidentCause = creationReport.AccidentCause;
                        report.LocationDescriptin = creationReport.LocationDescriptin;
                        report.ProcedureTypesId = creationReport.ProceduerTypeID;
                        //ByStreetsID = creationReport.ByStreetsID,
                        report.NationalitiesID = creationReport.NationalitiesID;                        
                        _report.UpdateReport(report);


                        return RedirectToAction(nameof(Index));
                    }

                    
               // }
                creationReport.MainCategories = _categories.GetAllMainCategories();
                creationReport.Nationalities = _nationalities.GetAllNationalities();
                creationReport.Districts = _addresses.GetAllDistricts();
                ViewBag.ErrorMessage = "Not found ";
                return View(creationReport);


            }
            catch (Exception ex)
            {
                creationReport.MainCategories = _categories.GetAllMainCategories();
                creationReport.Nationalities = _nationalities.GetAllNationalities();
                creationReport.Districts = _addresses.GetAllDistricts();
                ViewBag.ErrorMessage = ex;
                return View(creationReport);

            }
        }



        // GET: ReportController1/Delete/5
        public ActionResult Delete(int id, IFormCollection collection)
        {
            return View();
        }

        // POST: ReportController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            //Report report = _report.GetReport(id);
            //if (report == null)
            //    return View("NotFound");
            //_report.DeleteReport(report);
            return View("Deleted");
        }



    }
}

