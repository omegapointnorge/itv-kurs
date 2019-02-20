using CodeQuality.E1_Readability;
using System.Collections.Generic;

namespace CodeQuality.S1_Readability
{
    public class CustomerRegistry
    {
        private List<Customer> CustomerList { get; set; } = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            CustomerList.Add(customer);
        }
    }
}

