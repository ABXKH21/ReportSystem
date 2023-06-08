using ReportSystem.Context;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ReportSystem.Repo
{
    public class InformerRepository : IInformerRepository
    {
        private readonly ReportSysContext _reportSysContext;
        public InformerRepository(ReportSysContext reportSysContext)
        {
            this._reportSysContext = reportSysContext;
        }


        public Informer AddInformer(Informer informer)
        {
            if (informer == null)
            {
                throw new Exception();
            }

            _reportSysContext.Informers.Add(informer);
            _reportSysContext.SaveChanges();
            return informer;
        }

        public Informer DeleteInformer(int id)
        {
            Informer informer = _reportSysContext.Informers.Find(id);
            if (informer != null)
            {
                _reportSysContext.Informers.Remove(informer);
                _reportSysContext.SaveChanges();
            }
            return informer;
        }

        public List<Informer> GetAllInformer()
        {
            var temp = _reportSysContext.Informers.ToList();
            return temp;
        }

        public Informer GetInformer(int id)
        {
            var report = _reportSysContext.Informers.FirstOrDefault(c => c.Id == id);
            return report;
        }


        public Informer FindInformer(int id)
        {
            return  _reportSysContext.Informers.Find(id);            
        }

        public Informer UpdateInformer(Informer informer)
        {
            if (informer == null)
            {
                throw new Exception();
            }
            _reportSysContext.Informers.Update(informer);
            _reportSysContext.SaveChanges();
            return informer;

        }
    }
}
