using CoffeDemo.Entities;
namespace CoffeDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
            public virtual void Save(Customer customer)
        {
            System.Console.WriteLine("Saved to db : "+ customer.FirstName);
        }
    }
}