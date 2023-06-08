using Microsoft.AspNetCore.Mvc;
using ReportSystem.Context;
using ReportSystem.Models;
using ReportSystem.Repo;
using System;
using System.Linq;
using ReportSystem.ViewModels.LostViewModel;


namespace ReportSystem.Controllers
{
    public class LostController : Controller
    {
        private readonly INationalitiesRepository _nationalities;
        private readonly IInformerRepository _informer;
        private readonly ILostRepository _lost;
        private readonly ReportSysContext _context;


        public LostController(IInformerRepository informer,
                 INationalitiesRepository nationalities,
            ILostRepository lost , ReportSysContext context)
        {
            _informer = informer;             
            _nationalities = nationalities;
            _lost = lost;
            _context = context;
        }

        //[Authentication]
        public IActionResult Index(string Search)
        {
            if (Search != null)
            {                
                return View(_lost.GetLostByName(Search));
            }
            return View(_lost.GetAllLost());
        }



        // GET: ReportController1/Create
        public ActionResult Create(int id)
        {
            CreationLost creationLost = new CreationLost
            {
                Lost = new Lost(),                                
                NationalitiesList = _nationalities.GetGetAllNationalitiesIEnum(),
            };
            return View(creationLost);
            
        }


        // POST: ReportController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreationLost creationLost)
        {
            try
            {
                Informer informer = new Informer                
                {
                    NameInformer = creationLost.Lost.Informer.NameInformer,  
                    NationalIdentificationId = creationLost.Lost.Informer.NationalIdentificationId,
                    Phone_Number = creationLost.Lost.Informer.Phone_Number                                        
                };

                Informer newInformer = _informer.AddInformer(informer);

                Lost newLost = new Lost
                {
                    InformerId = newInformer.Id,
                    Subject = creationLost.Lost.Subject,
                    Department = creationLost.Lost.Department,   
                    CollageName = creationLost.Lost.CollageName, 
                    Address = creationLost.Lost.Address, 
                    Description = creationLost.Lost.Description, 
                    Job_UniversityID = creationLost.Lost.Job_UniversityID ,
                    LostDate = creationLost.Lost.LostDate,
                    NationalitiesID = creationLost.Lost.NationalitiesID,                    
                    OpenDate = creationLost.Lost.OpenDate,   
                    OpenTime = creationLost.Lost.OpenTime,   
                    PlaceLost = creationLost.Lost.PlaceLost,
                    Stealing = creationLost.Lost.Stealing ,
                    StealingInfo = creationLost.Lost.StealingInfo ,                    
                };
                _lost.AddLost(newLost);                

                TempData["SuccessCreate"] = "Saved successfully";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                CreationLost creation = new CreationLost
                {
                    Lost = new Lost(),                    
                    NationalitiesList = _nationalities.GetAllNationalities(),
                };
                ViewBag.ErrorMessage = ex;
                return View(creation);                                
            }
        }



        // GET: ReportController1/Details/5
        public ActionResult Details(int id)
        {            
            try
             {
                 return View(_lost.GetLost(id));
             }
             catch (Exception ex)
             {
                 ViewBag.ErrorMessage = ex;
                 return View();
             }
        }



        // GET: ReportController1/Edit/5
        public ActionResult Edit(int id)
        {          
            CreationLost creationLost = new CreationLost
            {
                Lost = _lost.GetLost(id),                
                //NationalitiesList = _nationalities.GetAllNationalities(),
                NationalitiesList = _nationalities.GetGetAllNationalitiesIEnum(),
            };
            return View(creationLost);
        }


        // POST: ReportController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, CreationLost creationLost)
        {
            try
            {
                if (ModelState.IsValid == true)
                {                    
                    if (id  != null)
                    {
                        Informer informer = _informer.FindInformer(creationLost.Lost.InformerId);
                        if (informer != null)
                        {
                            informer.NameInformer = creationLost.Lost.Informer.NameInformer;
                            informer.NationalIdentificationId = creationLost.Lost.Informer.NationalIdentificationId;
                            informer.Phone_Number = creationLost.Lost.Informer.Phone_Number;
                            _informer.UpdateInformer(informer);
                        }

                        Lost lost1 = _lost.FindLost((int)id);
                        if (lost1 != null)
                        {
                            /*lost1.InformerId = creationLost.Lost.InformerId;*/
                            lost1.Subject = creationLost.Lost.Subject;
                            lost1.Department = creationLost.Lost.Department;
                            lost1.CollageName = creationLost.Lost.CollageName;
                            lost1.Address = creationLost.Lost.Address;
                            lost1.Description = creationLost.Lost.Description;
                            lost1.Job_UniversityID = creationLost.Lost.Job_UniversityID;
                            lost1.LostDate = creationLost.Lost.LostDate;
                            /*lost1.NationalitiesID = creationLost.Lost.NationalitiesID;*/
                            lost1.OpenDate = creationLost.Lost.OpenDate;
                            lost1.OpenTime = creationLost.Lost.OpenTime;
                            lost1.PlaceLost = creationLost.Lost.PlaceLost;
                            lost1.Stealing = creationLost.Lost.Stealing;
                            lost1.StealingInfo = creationLost.Lost.StealingInfo;
                            _lost.UpdateLost(lost1);
                            TempData["SuccessCreate"] = "Update successfully";
                        }
                    }                  
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {                
                CreationLost creation = new CreationLost
                {
                    Lost = _lost.GetLost(creationLost.Lost.Id),                    
                    NationalitiesList = _nationalities.GetAllNationalities(),
                };
                ViewBag.ErrorMessage = e;
                return View(creation);
            }          

        }
    }
}
