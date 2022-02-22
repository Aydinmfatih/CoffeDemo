using CoffeDemo.Entities;
namespace CoffeDemo.Abstract
{
    public interface IPersonCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}