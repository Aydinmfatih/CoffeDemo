using CoffeDemo.Abstract;
using CoffeDemo.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CoffeDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer); 
            }
            throw new System.Exception("Not a valid Person");
           
            
           


        }
       
    }
}