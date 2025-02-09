using System.Collections.ObjectModel;
using WiredBrainCoffee.Data;
using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.ViewModel {
    public class CustomersViewModel
    {
        public CustomersViewModel(ICustomerDataProvider customerDataProvider) {
            _customerDataProvider = customerDataProvider;
        }
        public ObservableCollection<Customer> Customers { get; } = new();
        public ICustomerDataProvider _customerDataProvider { get; }

        public async Task LoadAsync() {
            if (Customers.Any()) {
                return;
            }

            var customers = await _customerDataProvider.GetAllAsync();
            if (customers is not null) {
                foreach (var customer in customers) {
                    Customers.Add(customer);
                }
            }
        }

    }
}
