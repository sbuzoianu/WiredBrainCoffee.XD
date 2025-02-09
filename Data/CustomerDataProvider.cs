using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.Data
{
    public interface ICustomerDataProvider {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }
    public class CustomerDataProvider : ICustomerDataProvider {
        public async Task<IEnumerable<Customer>?> GetAllAsync() {
            await Task.Delay(100); // Simulate a bit of server work

            return new List<Customer>
            {
                new Customer{Id=1,FirstName="Julia",LastName="Developer",IsDeveloper=true},
                new Customer{Id=2,FirstName="Alex",LastName="Tofan"},
                new Customer{Id=3, FirstName="Vlad",LastName="Constantinescu",IsDeveloper=true},
                new Customer{Id=4,FirstName="Ana",LastName="Bejan"},
                new Customer{Id=5,FirstName="Sara",LastName="Popescu"},
                new Customer{Id=6,FirstName="Andrei",LastName="Ciobotaru"}
            };
        }
    }
}
