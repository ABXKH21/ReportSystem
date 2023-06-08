using Microsoft.AspNetCore.Mvc;
using ReportSystem.Context;
using ReportSystem.Models;
using ReportSystem.Repo;
using System;

namespace ReportSystem.Controllers
{
    public class DeliveryController : Controller
    {

        private readonly IEmployeeRepository _employee;
        private readonly IDeliveryRepository _delivery;
        private readonly ReportSysContext _context;


        public DeliveryController(IEmployeeRepository employee,
            IDeliveryRepository repository, ReportSysContext context)
        {
            _employee = employee;
            _delivery = repository;
            _context = context;
        }

       // [Authentication]
        public IActionResult Index(string Search)
        {
            if (Search != null)
            {
                //return View(_context.Deliveries.Where (x => x.Employee.EmployeeName == searchName).ToList());
                return View(_delivery.GetDeliveryByName(Search));
            }
            return View(_delivery.GetAllDelivery());
        }



        // GET: ReportController1/Create
        public ActionResult Create(int id)
        {
            return View();
        }


        // POST: ReportController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Delivery delivery)
        {
            try
            {
                Employees newEmp = new Employees
                {
                    EmployeeName = delivery.Employee.EmployeeName,
                    Employer = delivery.Employee.Employer,
                    JobID = delivery.Employee.JobID,
                    Phone = delivery.Employee.Phone
                };
                Employees newEmployees = _employee.AddEmployee(newEmp);

                Delivery newDelivery = new Delivery
                {
                    EmployeeId = newEmployees.Id,
                    CarColor = delivery.CarColor,
                    CarModel = delivery.CarModel,
                    PlateNumber = delivery.PlateNumber,
                    CarType = delivery.CarType,
                };
                _delivery.AddDelivery(newDelivery);


                TempData["SuccessCreate"] = "Saved successfully";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex;
                return View();
            }
        }



        // GET: ReportController1/Details/5
        public ActionResult Details(int id)
        {
            //return View();          
            try
            {
                return View(_delivery.GetDelivery(id));
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
            try
            {
                return View(_delivery.GetDelivery(id));
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
        public ActionResult Edit(Delivery delivery)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    _employee.UpdateEmployee(delivery.Employee);

                    _delivery.UpdateDelivery(delivery);

                    /*
                                            Employees newEmp = new Employees
                                            {
                                                EmployeeName = delivery.Employee.EmployeeName,
                                                Employer = delivery.Employee.Employer,
                                                JobID = delivery.Employee.JobID,
                                                Phone = delivery.Employee.Phone
                                            };
                                            Employees newEmployees = _employee.UpdateEmployee(newEmp);

                                            Delivery newDelivery = new Delivery
                                            {
                                                EmployeeId = newEmployees.Id,
                                                CarColor = delivery.CarColor,
                                                CarModel = delivery.CarModel,
                                                PlateNumber = delivery.PlateNumber,
                                                CarType = delivery.CarType,
                                            };

                                            _delivery.UpdateDelivery(newDelivery);*/


                    TempData["SuccessCreate"] = "Update successfully";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex;
                    return View();
                }

            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
