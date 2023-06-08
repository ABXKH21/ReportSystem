using Microsoft.AspNetCore.Mvc;
using ReportSystem.Context;
using ReportSystem.Models;
using ReportSystem.Repo;
using System;

namespace ReportSystem.Controllers
{
    public class LostCardController : Controller
    {

        private readonly ILostCardRepository _repo;
        private readonly IEmployeeRepository _employee;
        private readonly ReportSysContext _context;

        public LostCardController( ILostCardRepository repo, 
            IEmployeeRepository employee,
            ReportSysContext context)
        {
            _repo = repo;            
            _employee = employee;
            _context = context;
        }


        // GET: LostCardEmployeesController1       
        public IActionResult Index(string Search)
        {
            if (Search != null)
            {               
                return View(_repo.GetLostCardEmployeeByName(Search));
            }
            return View(_repo.GetAllLostCardEmployee());                       
        }


        // GET: LostCardEmployeestController1/Create
        public ActionResult Create(int id)
        {            
            return View();
        }


        // POST: LostCardEmployeesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LostCardEmployee lostCard)
        {           
            try
            {
                Employees newEmp = new Employees
                {
                    EmployeeName = lostCard.Employee.EmployeeName,
                    Employer = lostCard.Employee.Employer,
                    JobID = lostCard.Employee.JobID,
                    Phone = lostCard.Employee.Phone
                };

                Employees newEmployees = _employee.AddEmployee(newEmp);

                LostCardEmployee lostCardEmployee = new LostCardEmployee
                {                   
                    EmployeeId = newEmployees.Id,
                    Reason = lostCard.Reason,
                };
                
                _repo.AddLostCardEmployee(lostCardEmployee);                
                TempData["SuccessCreate"] = "Saved successfully";
                return RedirectToAction(nameof(Index));                
            }
            catch (Exception ex)
            {              
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }


        // GET: LostCardEmployeesController1/Details/5
        public ActionResult Details(int id)
        {
            try
            {                
                return View(_repo.GetLostCardEmployee(id));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }




        // GET: LostCardEmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return View(_repo.GetLostCardEmployee(id));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }

        // POST: LostCardEmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LostCardEmployee lostCard)
        {
            try
            {
                if (ModelState.IsValid == true)
                {                  
                    _employee.UpdateEmployee(lostCard.Employee);                    
                    _repo.UpdateLostCardEmployee(lostCard);
                    _context.SaveChanges();
                }
                
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }
    }
}
