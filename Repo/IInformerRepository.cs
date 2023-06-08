using ReportSystem.Models;
using System.Collections.Generic;



namespace ReportSystem.Repo
{
    public interface IInformerRepository
    {

        Informer AddInformer(Informer informer);
        List<Informer> GetAllInformer();
        Informer GetInformer(int id);
        Informer FindInformer(int id);
        Informer DeleteInformer(int id);
        Informer UpdateInformer(Informer informer);
    }
}
