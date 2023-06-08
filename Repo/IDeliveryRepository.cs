using ReportSystem.Models;
using System.Collections.Generic;


namespace ReportSystem.Repo
{
    public interface IDeliveryRepository 
    {
        Delivery AddDelivery(Delivery delivery);
        List<Delivery> GetAllDelivery();
        Delivery GetDelivery(int id);
        List<Delivery> GetDeliveryByName(string name);        
        Delivery DeleteDelivery(int id);
        Delivery UpdateDelivery(Delivery delivery);
    }
}
