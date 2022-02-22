using CoffeDemo.Abstract;
using CoffeDemo.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
namespace CoffeDemo.Concrete
{
    public class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            
            return true;
        }
    }
}