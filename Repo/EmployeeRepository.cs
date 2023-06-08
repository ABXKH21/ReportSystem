
using ReportSystem.Context;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ReportSystem.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ReportSysContext _reportSysContext;

        public EmployeeRepository(ReportSysContext reportSysContext)
        {
            this._reportSysContext = reportSysContext;
        }


        public Employees AddEmployee(Employees employees)
        {
            if (employees == null)
            {
                throw new Exception();
            }

            _reportSysContext.Employees.Add(employees);
            _reportSysContext.SaveChanges();
            return employees;
        }

        public Employees DeleteEmployee(int id)
        {
            Employees employees = _reportSysContext.Employees.Find(id);
            if (employees != null)
            {               
                _reportSysContext.Employees.Remove(employees);
                _reportSysContext.SaveChanges();
            }
            return employees;
        }

        public List<Employees> GetAllEmployee()
        {
            var temp = _reportSysContext.Employees.ToList();
            return temp;
        }

        public Employees GetEmployee(int id)
        {
            var report = _reportSysContext.Employees.FirstOrDefault(c => c.Id == id);
            return report;
        }

        public Employees UpdateEmployee(Employees employees)
        {
            if (employees == null)
            {
                throw new Exception();
            }
            _reportSysContext.Employees.Update(employees);
            _reportSysContext.SaveChanges();
            return employees;

        }
    }
}
