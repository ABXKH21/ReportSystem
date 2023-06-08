using Microsoft.EntityFrameworkCore;
using ReportSystem.Context;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportSystem.Repo
{
    public class LostRepository : ILostRepository
    {

        private readonly ReportSysContext reportSysContext;
        public LostRepository(ReportSysContext reportSysContext)
        {
            this.reportSysContext = reportSysContext;
        }

        public Lost AddLost(Lost lost)
        {
            if (lost == null)
            {
                throw new Exception();
            }

            reportSysContext.Losts.Add(lost);
            reportSysContext.SaveChanges();
            return lost;
        }

        public Lost DeleteLost(int id)
        {
            Lost lost = reportSysContext.Losts.Find(id);

            if (lost != null)
            {                
                reportSysContext.Losts.Remove(lost);
                reportSysContext.SaveChanges();
            }
            return lost;
        }

        public List<Lost> GetAllLost()
        {            
            var temp = reportSysContext.Losts.Include(inr => inr.Informer)
                .Include(nat => nat.Nationalities).ToList();
            return temp;
        }

        public Lost GetLost(int id)
        {
            var delivery = reportSysContext.Losts.Include(inr => inr.Informer)
                .Include(nat => nat.Nationalities).FirstOrDefault(c => c.Id == id);
            return delivery;
        }


        public List<Lost> GetLostByName(string name)
        {
            /*var delivery = reportSysContext.Losts.Include(inr => inr.Informer)
                .Include(nat => nat.Nationalities).FirstOrDefault(c => c.Id == name);
            return delivery;*/

            List<Lost>  lostList = new List<Lost>();
            var lostData = reportSysContext.Losts.Include(inr => inr.Informer);
            if (lostData != null)
            {
                foreach (var row in lostData)
                {
                    if (row.Informer.NameInformer.Contains(name))
                    {
                        lostList.Add(row);                        
                    }
                }
            }
            return lostList;
        }
       


        public Lost FindLost(int id)
        {            
            Lost lost = reportSysContext.Losts.Find(id);
            return lost;
        }

        public Lost UpdateLost(Lost lost)
        {
            if (lost == null)
            {
                throw new Exception();
            }

            reportSysContext.Losts.Update(lost);
            reportSysContext.SaveChanges();
            return lost;
        }
    }
}
