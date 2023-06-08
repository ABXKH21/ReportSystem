using ReportSystem.Context;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace ReportSystem.Repo
{
    public class LostCardRepository : ILostCardRepository
    {

        private readonly ReportSysContext reportSysContext;


        public LostCardRepository (ReportSysContext reportSysContext)
        {
            this.reportSysContext = reportSysContext;
        }

        
        public LostCardEmployee AddLostCardEmployee(LostCardEmployee lostCardEmployee)
        {
            if (lostCardEmployee == null)
            {
                throw new Exception();
            }

            reportSysContext.LostCardEmployees.Add(lostCardEmployee);
            reportSysContext.SaveChanges();
            return lostCardEmployee;

        }

        public LostCardEmployee DeleteLostCardEmployee(int id)
        {
            LostCardEmployee lostCardEmployee = reportSysContext.LostCardEmployees.Find (id);

            if (lostCardEmployee != null)
            {
                reportSysContext.LostCardEmployees.Where(x => x.Id == id);
                reportSysContext.LostCardEmployees.Remove(lostCardEmployee);
                reportSysContext.SaveChanges();
            }
            return lostCardEmployee;
        }

        public List<LostCardEmployee> GetAllLostCardEmployee()
        {
            var temp = reportSysContext.LostCardEmployees.Include(emp => emp.Employee).ToList();
            return temp;
        }

        public LostCardEmployee GetLostCardEmployee(int id)
        {
            var report = reportSysContext.LostCardEmployees.Include (emp => emp.Employee).            
                FirstOrDefault(c => c.Id == id);
            return report;
        }

        public List<LostCardEmployee> GetLostCardEmployeeByName(string  name)
        {           
            List<LostCardEmployee> lostCards = new List<LostCardEmployee>();
            var lostCards1 = reportSysContext.LostCardEmployees.Include(emp => emp.Employee);                        
            if (lostCards1 != null)
            {
                foreach (var row in lostCards1)
                {
                    if (row.Employee.EmployeeName.Contains(name))
                    {
                        lostCards.Add(row);
                    }
                }                
            }
            return lostCards;          
        }

        public LostCardEmployee UpdateLostCardEmployee(LostCardEmployee lostCard)
        {
            if (lostCard == null)
            {
                throw new Exception();
            }

            reportSysContext.LostCardEmployees.Update(lostCard);
            reportSysContext.SaveChanges();
            return lostCard;
        }
    }
}
