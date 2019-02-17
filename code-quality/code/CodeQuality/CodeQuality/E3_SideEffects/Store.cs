using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E3_SideEffects
{
    public class Store
    {
        private List<Customer> CustomerList { get; set; } = new List<Customer>();

        public void AddNewCustomerForStore(Customer customer)
        {
            CustomerList.Add(customer);
            
            GenerateAccountForCustomer(customer);

            UpdateCustomerStatistics(customer);

            SendWelComeEmailToCustomer(customer);

        }

        private void GenerateAccountForCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private void UpdateCustomerStatistics(Customer customer)
        {
            throw new NotImplementedException();
        }

        private void SendWelComeEmailToCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

