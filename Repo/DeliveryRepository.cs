using Microsoft.EntityFrameworkCore;
using ReportSystem.Context;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportSystem.Repo
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ReportSysContext _reportSysContext;

        public DeliveryRepository(ReportSysContext reportSysContext)
        {
            this._reportSysContext = reportSysContext;
        }


        public Delivery AddDelivery(Delivery delivery)
        {
            if (delivery == null)
            {
                throw new Exception();
            }

            _reportSysContext.Deliveries.Add(delivery);
            _reportSysContext.SaveChanges();
            return delivery;
        }

        public Delivery DeleteDelivery(int id)
        {
            Delivery  delivery = _reportSysContext.Deliveries.Find(id);
            if (delivery != null)
            {                
                _reportSysContext.Deliveries.Remove(delivery);
                _reportSysContext.SaveChanges();
            }
            return delivery;
        }

        public List<Delivery> GetAllDelivery()
        {
            var temp = _reportSysContext.Deliveries.Include(emp => emp.Employee).ToList();
            return temp;
        }

        public  Delivery GetDelivery(int id)
        {
           var  delivery = _reportSysContext.Deliveries.Include(emp => emp.Employee).FirstOrDefault(c => c.Id == id);
            return delivery;
        }

        public List<Delivery> GetDeliveryByName(string searchName)
        {
            

            List<Delivery>  deliveries = new List<Delivery>();
            var delivery = _reportSysContext.Deliveries.Include(emp => emp.Employee);
            if (delivery != null)
            {
                foreach (var row in delivery)
                {
                    if (row.Employee.EmployeeName.Contains(searchName))
                    {
                        deliveries.Add(row);
                    }
                }
            }
            return deliveries;
        }

        public Delivery UpdateDelivery(Delivery delivery)
        {
            if (delivery == null)
            {
                throw new Exception();
            }

            _reportSysContext.Deliveries.Update(delivery);
            _reportSysContext.SaveChanges();
            return delivery;
        }
    }
}
